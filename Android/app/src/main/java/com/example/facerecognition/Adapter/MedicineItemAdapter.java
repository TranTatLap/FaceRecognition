package com.example.facerecognition.Adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.AnimationUtils;
import android.widget.RelativeLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.recyclerview.widget.RecyclerView;

import com.example.facerecognition.Class.Medicine;
import com.example.facerecognition.R;

import java.util.List;

public class MedicineItemAdapter extends RecyclerView.Adapter<MedicineItemAdapter.ViewHolder> {
    Context context;
    List<Medicine> list;

    public MedicineItemAdapter(Context context, List<Medicine> list) {
        this.context = context;
        this.list = list;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        return new ViewHolder(LayoutInflater.from(context).inflate(R.layout.item_medicine, parent, false));
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {

        holder.layout.startAnimation(AnimationUtils.loadAnimation(context,R.anim.scroll));

        holder.name.setText(list.get(position).name);
        holder.dose.setText(String.valueOf(list.get(position).dose));
        holder.session.setText(list.get(position).session);
        holder.total.setText(String.valueOf(list.get(position).total));

    }

    @Override
    public int getItemCount() {
        return list.size();
    }

    public static class ViewHolder extends RecyclerView.ViewHolder{
        ConstraintLayout layout;
        TextView name,dose,session,total;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            name = itemView.findViewById(R.id.tv_med_name);
            dose = itemView.findViewById(R.id.tv_med_dose);
            session = itemView.findViewById(R.id.tv_med_session);
            total = itemView.findViewById(R.id.tv_med_total);
            layout = itemView.findViewById(R.id.layout);
        }
    }

}
