package com.example.facerecognition;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.util.Log;
import android.util.Patterns;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;

import com.example.facerecognition.Class.User;
import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseAuthInvalidCredentialsException;
import com.google.firebase.auth.FirebaseAuthUserCollisionException;
import com.google.firebase.auth.FirebaseAuthWeakPasswordException;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.time.Month;
import java.util.Calendar;
import java.util.GregorianCalendar;

public class RegisterActivity extends AppCompatActivity {
    EditText edt_Email, edt_Password, edt_Confirm, edt_Name, edt_Dob;
    Button btn_register;
    TextView tv_loginNow;
    FirebaseAuth mAuth;

    ProgressBar progressBar;

    DatePickerDialog pickerDialog;
    static final String TAG = "RegisterActivity";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);
        initView();
        initEvent();
    }

    private void initEvent() {
        tv_loginNow.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent  = new Intent(getApplicationContext(),LoginActivity.class);
                startActivity(intent);
                finish();
            }
        });

        edt_Dob.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                final Calendar calendar = Calendar.getInstance();
                int day = calendar.get(Calendar.DAY_OF_MONTH);
                int month = calendar.get(Calendar.MONTH);
                int year = calendar.get(Calendar.YEAR);

                pickerDialog = new DatePickerDialog(RegisterActivity.this, new DatePickerDialog.OnDateSetListener() {
                    @Override
                    public void onDateSet(DatePicker datePicker, int year, int month, int day) {
                        edt_Dob.setText(day+"/"+(month+1)+"/"+year);
                    }
                },year,month,day);
                pickerDialog.show();
            }

        });

        btn_register.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String email, password, confirm, name, dob;
                email = edt_Email.getText().toString();
                password = edt_Password.getText().toString();
                confirm = edt_Confirm.getText().toString();
                name = edt_Name.getText().toString();
                dob = edt_Dob.getText().toString();

                if(TextUtils.isEmpty(name)){
                    edt_Name.setError("Full name is required");
                    edt_Name.requestFocus();
                } else if (TextUtils.isEmpty(email)) {
                    edt_Email.setError("Email is required");
                    edt_Email.requestFocus();
                } else if (!Patterns.EMAIL_ADDRESS.matcher(email).matches()) {
                    edt_Email.setError("Valid email is required");
                    edt_Email.requestFocus();
                } else if (TextUtils.isEmpty(password)){
                    edt_Password.setError("Password is required");
                    edt_Password.requestFocus();
                } else if (password.length() < 6) {
                    edt_Password.setError("Password must be at least 6 characters");
                    edt_Password.requestFocus();
                } else if (TextUtils.isEmpty(confirm)) {
                    edt_Confirm.setError("Confirm password is required");
                    edt_Confirm.requestFocus();
                } else if (!password.equals(confirm)) {
                    edt_Confirm.setError("Confirm password is incorrect");
                    edt_Confirm.requestFocus();
                }else {
                    progressBar.setVisibility(View.VISIBLE);
                    register(email, password, name, dob);
                }

            }
        });
    }

    private void register(String email, String password, String name, String dob) {
        mAuth = FirebaseAuth.getInstance();
        mAuth.createUserWithEmailAndPassword(email, password).addOnCompleteListener(new OnCompleteListener<AuthResult>() {
                    @Override
                    public void onComplete(@NonNull Task<AuthResult> task) {
                        if (task.isSuccessful()) {
                            FirebaseUser firebaseUser = mAuth.getCurrentUser();

                            User user = new User(name,dob);
                            DatabaseReference reference = FirebaseDatabase.getInstance().getReference("Users");
                            reference.child(firebaseUser.getUid()).setValue(user).addOnCompleteListener(new OnCompleteListener<Void>() {
                                @Override
                                public void onComplete(@NonNull Task<Void> task) {
                                    if(task.isSuccessful()){
                                        Toast.makeText(RegisterActivity.this, "User registered successfully!",
                                                Toast.LENGTH_LONG).show();
                                        firebaseUser.sendEmailVerification();

                                        Intent intent = new Intent(getApplicationContext(), LoginActivity.class);
                                        startActivity(intent);
                                        finish();
                                    }else {
                                        Toast.makeText(RegisterActivity.this, "User registered failed. Please try again!",
                                                Toast.LENGTH_LONG).show();
                                    }
                                    progressBar.setVisibility(View.INVISIBLE);
                                }
                            });




                        } else {
                            try{
                                throw task.getException();
                            } catch (FirebaseAuthWeakPasswordException e){
                                edt_Password.setError("Your password is too weak.");
                                edt_Password.requestFocus();
                            } catch (FirebaseAuthInvalidCredentialsException e){
                                edt_Email.setError("Your email is invalid or already in use.");
                                edt_Email.requestFocus();
                            } catch (FirebaseAuthUserCollisionException e){
                                edt_Email.setError("Your email is already in use.");
                                edt_Email.requestFocus();
                            } catch (Exception e){
                                Log.e(TAG, e.getMessage() );
                                Toast.makeText(RegisterActivity.this, e.getMessage(), Toast.LENGTH_SHORT).show();
                            }
                            progressBar.setVisibility(View.INVISIBLE);
                        }
                    }
        });

    }

    private void initView() {
        btn_register = (Button) findViewById(R.id.btn_register);
        edt_Password = (EditText) findViewById(R.id.edt_password);
        edt_Email = (EditText) findViewById(R.id.edt_email);
        edt_Confirm = (EditText) findViewById(R.id.edt_confirm);
        tv_loginNow = (TextView) findViewById(R.id.tv_loginNow);
        edt_Name = (EditText) findViewById(R.id.edt_name);
        edt_Dob = (EditText) findViewById(R.id.edt_dob);
        progressBar = (ProgressBar) findViewById(R.id.progressbar);

    }
}