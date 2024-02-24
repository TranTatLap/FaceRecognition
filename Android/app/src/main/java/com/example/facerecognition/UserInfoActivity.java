package com.example.facerecognition;

import androidx.activity.result.ActivityResult;
import androidx.activity.result.ActivityResultCallback;
import androidx.activity.result.ActivityResultLauncher;
import androidx.activity.result.contract.ActivityResultContracts;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Color;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.util.Base64;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

import com.example.facerecognition.Class.Patient;
import com.example.facerecognition.Class.User;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.Calendar;

public class UserInfoActivity extends AppCompatActivity {
    EditText edt_name, edt_dob,edt_email;
    ImageView imv_avatar;
    Button btn_logout;
    DatePickerDialog pickerDialog;
    ActivityResultLauncher<Intent> resultLauncher;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_userinfo);
        initView();
        initEvent();
        registerResult();

    }

    private void initEvent() {
        edt_email.setEnabled(false);
        edt_email.setTextColor(Color.parseColor("#000000"));
        FirebaseUser firebaseUser = FirebaseAuth.getInstance().getCurrentUser();
        if(firebaseUser == null){
            Toast.makeText(UserInfoActivity.this, "Something went wrong! User's information are not available at the moment.",
                    Toast.LENGTH_LONG).show();
        }
        else{
            showInfo(firebaseUser);
        }
        btn_logout.setOnClickListener(v -> {
            FirebaseAuth.getInstance().signOut();
            startActivity(new Intent(UserInfoActivity.this, LoginActivity.class));
            finish();
        });
        imv_avatar.setOnClickListener(v -> {
            selectImg();
        });
        edt_dob.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final Calendar calendar = Calendar.getInstance();
                int day = calendar.get(Calendar.DAY_OF_MONTH);
                int month = calendar.get(Calendar.MONTH);
                int year = calendar.get(Calendar.YEAR);

                pickerDialog = new DatePickerDialog(UserInfoActivity.this, new DatePickerDialog.OnDateSetListener() {
                    @Override
                    public void onDateSet(DatePicker datePicker, int year, int month, int day) {
                        edt_dob.setText(day+"/"+(month+1)+"/"+year);
                    }
                },year,month,day);
                pickerDialog.show();
            }

        });
    }

    private void selectImg() {
        Intent intent = new Intent(MediaStore.ACTION_PICK_IMAGES);
        resultLauncher.launch(intent);
    }

    private void registerResult(){
        resultLauncher = registerForActivityResult(
                new ActivityResultContracts.StartActivityForResult(),
                result -> {
                    try{
                        Uri imgUri = result.getData().getData();
                        imv_avatar.setImageURI(imgUri);
                    }catch (Exception ex){
                        Toast.makeText(UserInfoActivity.this,"No image selected",Toast.LENGTH_LONG).show();
                    }
                }
        );
    }


    private void showInfo(FirebaseUser firebaseUser) {
        FirebaseDatabase.getInstance().getReference("Users").child(firebaseUser.getUid()).addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                User user = snapshot.getValue(User.class);
                if(user!=null){
                    edt_name.setText(user.Fullname);
                    edt_email.setText(firebaseUser.getEmail());
                    edt_dob.setText(user.Dob);

                    if(user.Img != null){
                        byte[] decodedBytes = Base64.decode(user.Img, Base64.DEFAULT);
                        Bitmap bm = BitmapFactory.decodeByteArray(decodedBytes, 0, decodedBytes.length);
                        imv_avatar.setImageBitmap(bm);
                    }
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });
    }

    private void initView() {
        edt_dob = (EditText) findViewById(R.id.edt_dob);
        edt_name = (EditText) findViewById(R.id.edt_Name);
        edt_email = (EditText) findViewById(R.id.edt_email);
        imv_avatar = (ImageView) findViewById(R.id.imv_avatar);
        btn_logout= (Button) findViewById(R.id.btn_logout);

    }
}