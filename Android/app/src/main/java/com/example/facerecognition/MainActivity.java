package com.example.facerecognition;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Intent;
import android.graphics.Bitmap;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;
import com.google.zxing.BarcodeFormat;
import com.google.zxing.MultiFormatWriter;
import com.google.zxing.WriterException;
import com.google.zxing.common.BitMatrix;
import com.journeyapps.barcodescanner.BarcodeEncoder;

public class MainActivity extends AppCompatActivity {

    Button btn, btn_scan,btn_userinfo;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btn = (Button) findViewById(R.id.btn_generate);
        btn_scan = (Button) findViewById(R.id.btn_scan);
        btn_userinfo = (Button) findViewById(R.id.btn_userinfo);

        btn_scan.setOnClickListener(v -> {
            Intent intent = new Intent(getApplicationContext(), ScanQRActivity.class);
            startActivity(intent);
        });

        btn.setOnClickListener(v -> {
            Intent intent = new Intent(getApplicationContext(), GenerateQRActivity.class);
            startActivity(intent);
        });

        btn_userinfo.setOnClickListener(view -> {
            Intent intent = new Intent(getApplicationContext(), UserInfoActivity.class);
            startActivity(intent);
        });

    }

}