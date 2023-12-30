package com.example.facerecognition;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.example.facerecognition.Class.Medicine;
import com.example.facerecognition.Class.Patient;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class SessionFragment extends Fragment {

    View view;
    ScanQRActivity scanQRActivity;
    TextView tv_morning, tv_noon, tv_evening;

    @Override
    public void onResume() {
        super.onResume();
        initEvent();
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_session, container, false);

        initView();
        initEvent();

        return view;
    }

    private void initEvent() {
        if(Medicine.medicine_List_static != null){
            StringBuilder mor = new StringBuilder();
            StringBuilder noon = new StringBuilder();
            StringBuilder eve = new StringBuilder();

            for (Medicine item :Medicine.medicine_List_static) {
                if(item.session.contains("morning")){
                    mor.append(item.name + "\n");
                    mor.append("Dose: " + item.dose  + "\n\n");

                }

                if(item.session.contains("noon")){
                    noon.append(item.name + "\n");
                    noon.append("Dose: " + item.dose  + "\n\n");
                }

                if(item.session.contains("evening")){
                    eve.append(item.name + "\n");
                    eve.append("Dose: " + item.dose  + "\n\n");
                }
            }

            tv_morning.setText(mor);
            tv_noon.setText(noon);
            tv_evening.setText(eve);

        }
    }

    private void initView() {
        scanQRActivity = (ScanQRActivity) getActivity();

        tv_evening = (TextView) view.findViewById(R.id.tv_evening);
        tv_morning = (TextView) view.findViewById(R.id.tv_morning);
        tv_noon = (TextView) view.findViewById(R.id.tv_noon);

    }
}