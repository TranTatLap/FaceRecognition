package com.example.facerecognition;

import android.annotation.SuppressLint;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.util.Base64;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.ImageView;

import com.example.facerecognition.Class.Patient;

public class InfoFragment extends Fragment {

    View view;
    ScanQRActivity scanQRActivity;
    ImageView imageView;
    EditText edt_id, edt_name, edt_disease, edt_phone, edt_dob;
    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_info, container, false);

        initView();
        initEvent();
        return view;
    }

    @SuppressLint("SetTextI18n")
    private void initEvent() {
        if(Patient.patient_static != null){
            if(Patient.patient_static.Id != null) {
                edt_id.setText("ID: " + Patient.patient_static.Id);
                edt_name.setText("Name: " + Patient.patient_static.Name);
                edt_disease.setText("Disease: " + Patient.patient_static.Disease);
                edt_phone.setText("Phone: " + Patient.patient_static.Phone);
                edt_dob.setText("Date of birth: " + Patient.patient_static.dob);
            }
            if(Patient.patient_static.img != null) {
                byte[] decodedBytes = Base64.decode(Patient.patient_static.img, Base64.DEFAULT);
                Bitmap bm = BitmapFactory.decodeByteArray(decodedBytes, 0, decodedBytes.length);
                imageView.setImageBitmap(bm);
            }

        }
    }

    @Override
    public void onResume() {
        super.onResume();
        initEvent();
    }

    private void initView() {
        scanQRActivity = (ScanQRActivity) getActivity();
        imageView = (ImageView) view.findViewById(R.id.imageView);
        edt_id= (EditText) view.findViewById(R.id.edt_ID);
        edt_name= (EditText) view.findViewById(R.id.edt_Name);
        edt_disease= (EditText) view.findViewById(R.id.edt_Disease);
        edt_phone= (EditText) view.findViewById(R.id.edt_Phone);
        edt_dob= (EditText) view.findViewById(R.id.edt_dob);

    }
}