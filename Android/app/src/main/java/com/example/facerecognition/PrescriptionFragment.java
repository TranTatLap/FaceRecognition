package com.example.facerecognition;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.example.facerecognition.Adapter.MedicineItemAdapter;
import com.example.facerecognition.Class.Medicine;

public class PrescriptionFragment extends Fragment {

    View view;
    ScanQRActivity scanQRActivity;
    RecyclerView recyclerView;

    @Override
    public void onResume() {
        super.onResume();
        recyclerView.setLayoutManager(new LinearLayoutManager(scanQRActivity));
        MedicineItemAdapter adapter = new MedicineItemAdapter(getContext(), Medicine.medicine_List_static);
        recyclerView.setAdapter(adapter);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.fragment_prescription, container, false);
        recyclerView = (RecyclerView) view.findViewById(R.id.rv_medicine);
        scanQRActivity = (ScanQRActivity) getActivity();

        recyclerView.setLayoutManager(new LinearLayoutManager(scanQRActivity));
        MedicineItemAdapter adapter = new MedicineItemAdapter(getContext(), Medicine.medicine_List_static);
        recyclerView.setAdapter(adapter);
        return view;
    }
}