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
import android.widget.ProgressBar;
import android.widget.Toast;

import com.example.facerecognition.Class.Patient;
import com.example.facerecognition.Class.User;
import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.io.ByteArrayOutputStream;
import java.util.Calendar;

public class UserInfoActivity extends AppCompatActivity {
    EditText edt_name, edt_dob,edt_email;
    ImageView imv_avatar;
    Button btn_logout,btn_update;
    DatePickerDialog pickerDialog;
    ActivityResultLauncher<Intent> resultLauncher;

    ProgressBar progressBar;
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
            Intent intent = new Intent(getApplicationContext(), LoginActivity.class);
//            intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
            startActivity(intent);
            finishAffinity();
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
                        if(++month>=10){
                            edt_dob.setText(day+"/"+month+"/"+year);
                        }else edt_dob.setText(day+"/"+"0"+month+"/"+year);

                    }
                },year,month,day);
                pickerDialog.show();
            }

        });

        btn_update.setOnClickListener(v -> {
            try {
                progressBar.setVisibility(View.VISIBLE);
                imv_avatar.setDrawingCacheEnabled(true);
                imv_avatar.buildDrawingCache();
                Bitmap bitmap = imv_avatar.getDrawingCache();

                // Chuyển đổi hình ảnh thành một chuỗi base64
                String base64String = bitmapToBase64(bitmap);

                User user = new User(edt_name.getText().toString(),edt_dob.getText().toString(), edt_email.getText().toString(), base64String);
                DatabaseReference reference = FirebaseDatabase.getInstance().getReference("Users");
                reference.child(firebaseUser.getUid()).setValue(user).addOnCompleteListener(new OnCompleteListener<Void>() {
                    @Override
                    public void onComplete(@NonNull Task<Void> task) {
                        if(task.isSuccessful()){
                            Toast.makeText(getApplicationContext(), "User information updated successfully!",
                                    Toast.LENGTH_LONG).show();
                        }else {
                            Toast.makeText(getApplicationContext(), "User information updated failed. Please try again!",
                                    Toast.LENGTH_LONG).show();
                        }
                        progressBar.setVisibility(View.INVISIBLE);
                    }
                });
            }catch (Exception e){
                Toast.makeText(getApplicationContext(), "User information updated failed. Please try again!",
                        Toast.LENGTH_LONG).show();
            };

        });
    }
    private String bitmapToBase64(Bitmap bitmap) {
        ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
        bitmap.compress(Bitmap.CompressFormat.PNG, 100, byteArrayOutputStream);
        byte[] byteArray = byteArrayOutputStream.toByteArray();
        return Base64.encodeToString(byteArray, Base64.DEFAULT);
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
        btn_update= (Button) findViewById(R.id.btn_update);
        progressBar= (ProgressBar) findViewById(R.id.progressbar);

    }
}