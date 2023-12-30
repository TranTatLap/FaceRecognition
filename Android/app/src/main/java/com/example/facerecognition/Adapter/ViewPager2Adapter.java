package com.example.facerecognition.Adapter;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.viewpager2.adapter.FragmentStateAdapter;

import com.example.facerecognition.InfoFragment;
import com.example.facerecognition.PrescriptionFragment;
import com.example.facerecognition.SessionFragment;


public class ViewPager2Adapter extends FragmentStateAdapter {


    public ViewPager2Adapter(@NonNull FragmentActivity fragmentActivity) {
        super(fragmentActivity);
    }

    @NonNull
    @Override
    public Fragment createFragment(int position) {
        switch (position){
            case 1:
                return new SessionFragment();
            case 2:
                return new PrescriptionFragment();
            default:
                return new InfoFragment();
        }
    }

    @Override
    public int getItemCount() {
        return 3;
    }
}
