package com.example.facerecognition;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.viewpager2.widget.ViewPager2;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.util.Log;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.facerecognition.Adapter.DepthPageTransformer;
import com.example.facerecognition.Adapter.ViewPager2Adapter;
import com.example.facerecognition.Class.Medicine;
import com.example.facerecognition.Class.Patient;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.android.material.navigation.NavigationBarView;
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
    ViewPager2 viewPager2;
    BottomNavigationView bottomNavigationView;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_scan_qractivity);

        initView();
        initEvent();

    }
    private void initView() {
        btn = (Button) findViewById(R.id.btn_scanner);
        btn_get = (Button) findViewById(R.id.btn_get);
        edt = (EditText) findViewById(R.id.edt_ID);

        viewPager2 = (ViewPager2) findViewById(R.id.view_pager2);
        bottomNavigationView = (BottomNavigationView) findViewById(R.id.bottom_navigation);



    }
    private void initEvent() {
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
                Toast.makeText(getApplicationContext(),"Patient ID cannot be blanked",Toast.LENGTH_SHORT).show();
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
                    String disease = snapshot.child("Disease").getValue(String.class);
                    String img = snapshot.child("Img").getValue(String.class);

                    Patient.patient_static = new Patient(id, name, disease, phone, dob, startDate, endDate, img);
                    edt.setText(Patient.patient_static.Id);
                    Toast.makeText(getApplicationContext(),"Patient information was retrieved successfully",Toast.LENGTH_SHORT).show();

                }
                @Override
                public void onCancelled(@NonNull DatabaseError error) {
                }
            });

            FirebaseDatabase.getInstance().getReference().child("Prescriptions").child(ID).addValueEventListener(new ValueEventListener() {
                @Override
                public void onDataChange(@NonNull DataSnapshot snapshot) {
                    Medicine.medicine_List_static.clear();
                    for (DataSnapshot item:snapshot.getChildren()) {
                        Log.d("AAA", "onDataChange: " +item.toString());
                        Medicine medicine = item.getValue(Medicine.class);
                        Medicine.medicine_List_static.add(medicine);

                    }

                }
                @Override
                public void onCancelled(@NonNull DatabaseError error) {
                }
            });

        });

        ViewPager2Adapter adapter = new ViewPager2Adapter(this);
        viewPager2.setAdapter(adapter);
        viewPager2.setPageTransformer(new DepthPageTransformer());
        viewPager2.registerOnPageChangeCallback(new ViewPager2.OnPageChangeCallback() {
            @Override
            public void onPageSelected(int position) {
                super.onPageSelected(position);

                switch (position){
                    case 0:
                        bottomNavigationView.getMenu().findItem(R.id.menu_info).setChecked(true);
                        break;
                    case 1:
                        bottomNavigationView.getMenu().findItem(R.id.menu_session).setChecked(true);
                        break;
                    case 2:
                        bottomNavigationView.getMenu().findItem(R.id.menu_prescription).setChecked(true);
                        break;
                }
            }
        });

        bottomNavigationView.setOnItemSelectedListener(new NavigationBarView.OnItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {
                    switch (item.getItemId()){
                        case 2131231001:
                            viewPager2.setCurrentItem(0);
                            break;
                        case 2131231003:
                            viewPager2.setCurrentItem(1);
                            break;
                        case 2131231002:
                            viewPager2.setCurrentItem(2);
                            break;

                    }
                return true;
            }
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