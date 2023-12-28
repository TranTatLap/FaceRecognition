package com.example.facerecognition;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.facerecognition.Class.Patient;
import com.google.firebase.Firebase;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;
import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

import java.util.ArrayList;
import java.util.List;

public class ScanQRActivity extends AppCompatActivity {

    Button btn,btn_get;
    EditText edt;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_scan_qractivity);

        btn = (Button) findViewById(R.id.btn_scanner);
        btn_get = (Button) findViewById(R.id.btn_get);
        edt = (EditText) findViewById(R.id.edt_ID);

        btn.setOnClickListener(v -> {
            IntentIntegrator intentIntegrator = new IntentIntegrator(ScanQRActivity.this);
            intentIntegrator.setOrientationLocked(true);
            intentIntegrator.setPrompt("Scan a QR Code");
            intentIntegrator.setDesiredBarcodeFormats(IntentIntegrator.QR_CODE);
            intentIntegrator.initiateScan();

        });
        btn_get.setOnClickListener(v -> {
            String ID = edt.getText().toString().trim();
            if(ID.equals("")){
                return;
            }
            FirebaseDatabase.getInstance().getReference().child("Patients").child(ID).addValueEventListener(new ValueEventListener() {
                @Override
                public void onDataChange(@NonNull DataSnapshot snapshot) {
                    String id = snapshot.child("Id").getValue(String.class);
                    String name = snapshot.child("Name").getValue(String.class);
                    String phone = snapshot.child("Phone").getValue(String.class);
                    String dob = snapshot.child("dob").getValue(String.class);
                    String startDate = snapshot.child("start_date").getValue(String.class);
                    String endDate = snapshot.child("end_date").getValue(String.class);
                    String disease = snapshot.child("Diasease").getValue(String.class);

                    Patient.patient_static = new Patient(id, name, disease, phone, dob, startDate, endDate);
                    edt.setText(Patient.patient_static.Id);

                }

                @Override
                public void onCancelled(@NonNull DatabaseError error) {
                }
            });

            FirebaseDatabase.getInstance().getReference().child("Images").child(ID).addValueEventListener(new ValueEventListener() {
                @Override
                public void onDataChange(@NonNull DataSnapshot snapshot) {
                    String base64String = snapshot.child("Img").getValue(String.class);
                    Patient.patient_static.img = base64String;
                    InfoFragment infoFragment = new InfoFragment();
                    getSupportFragmentManager().beginTransaction().replace(R.id.container,infoFragment).commit();

                }

                @Override
                public void onCancelled(@NonNull DatabaseError error) {
                }
            });

        });


    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        IntentResult intentResult = IntentIntegrator.parseActivityResult(requestCode,resultCode,data);
        if(intentResult != null)
        {
            String contents = intentResult.getContents();
            if(contents != null){
               edt.setText(intentResult.getContents());
            }else {
                super.onActivityResult(requestCode, resultCode, data);
            }
        }
    }
}