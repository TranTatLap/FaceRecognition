package com.example.facerecognition;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

import com.example.facerecognition.Class.User;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class UserInfoActivity extends AppCompatActivity {
    EditText edt_name, edt_dob,edt_email;
    ImageView imv_avatar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_userinfo);
        initView();
        initEvent();

    }

    private void initEvent() {
        FirebaseUser firebaseUser = FirebaseAuth.getInstance().getCurrentUser();
        if(firebaseUser == null){
            Toast.makeText(UserInfoActivity.this, "Something went wrong! User's information are not available at the moment.",
                    Toast.LENGTH_LONG).show();
        }
        else{
            showInfo(firebaseUser);
        }
    }

    private void showInfo(FirebaseUser firebaseUser) {
        FirebaseDatabase.getInstance().getReference("Users").child(firebaseUser.getUid()).addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                User user = snapshot.getValue(User.class);
                if(user!=null){
                    edt_name.setText(user.Name);
                    edt_email.setText(firebaseUser.getEmail());
                    edt_dob.setText(user.Dob);
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

    }
}