package com.example.facerecognition;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Bitmap;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

import com.google.zxing.BarcodeFormat;
import com.google.zxing.MultiFormatWriter;
import com.google.zxing.WriterException;
import com.google.zxing.common.BitMatrix;
import com.journeyapps.barcodescanner.BarcodeEncoder;

public class MainActivity extends AppCompatActivity {

    Button btn, btn_scan;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btn = (Button) findViewById(R.id.btn_generate);
        btn_scan = (Button) findViewById(R.id.btn_scan);

        btn_scan.setOnClickListener(v -> {
            Intent intent = new Intent(getApplicationContext(), ScanQRActivity.class);
            startActivity(intent);
            finish();
        });

        btn.setOnClickListener(v -> {
            Intent intent = new Intent(getApplicationContext(), GenerateQRActivity.class);
            startActivity(intent);
            finish();

        });


    }

}