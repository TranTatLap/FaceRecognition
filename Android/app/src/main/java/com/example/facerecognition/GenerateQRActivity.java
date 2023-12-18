package com.example.facerecognition;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Bitmap;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

import com.google.zxing.BarcodeFormat;
import com.google.zxing.MultiFormatWriter;
import com.google.zxing.WriterException;
import com.google.zxing.common.BitMatrix;
import com.journeyapps.barcodescanner.BarcodeEncoder;

public class GenerateQRActivity extends AppCompatActivity {
    EditText edt_id;
    Button btn;
    ImageView iv_qr;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_generate_qractivity);
        edt_id = (EditText) findViewById(R.id.edt_ID);
        btn = (Button) findViewById(R.id.btn_generate);
        iv_qr = (ImageView) findViewById(R.id.iv_QR);

        btn.setOnClickListener(v -> {
            generateQR();

        });

    }

    private void generateQR() {
        String input = edt_id.getText().toString().trim();
        MultiFormatWriter writer = new MultiFormatWriter();

        if(input.equals("")){
            return;
        }
        try {
            BitMatrix matrix = writer.encode(input, BarcodeFormat.QR_CODE, 400,400);
            BarcodeEncoder encoder = new BarcodeEncoder();
            Bitmap bitmap = encoder.createBitmap(matrix);
            iv_qr.setImageBitmap(bitmap);
        } catch (WriterException e) {
            throw new RuntimeException(e);
        }

    }
}