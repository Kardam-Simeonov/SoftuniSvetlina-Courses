package com.example.recyclerviewexample;

import android.app.Person;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class Person_RecyclerViewAdapter extends RecyclerView.Adapter<Person_RecyclerViewAdapter.MyViewHolder> {
    Context context;
    ArrayList<PersonModel> personModels;

    public Person_RecyclerViewAdapter(Context context, ArrayList<PersonModel> personModels){
        this.context = context;
        this.personModels = personModels;
    }

    @NonNull
    @Override
    public Person_RecyclerViewAdapter.MyViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(context);
        View view = inflater.inflate(R.layout.recycler_view_row, parent, false);

        return new Person_RecyclerViewAdapter.MyViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull Person_RecyclerViewAdapter.MyViewHolder holder, int position) {
        holder.firstNameView.setText(personModels.get(position).getFirstName());
        holder.lastNameView.setText(personModels.get(position).getLastName());
        holder.imageView.setImageResource(personModels.get(position).getImage());
    }

    @Override
    public int getItemCount() {
        return personModels.size();
    }

    public static class MyViewHolder extends RecyclerView.ViewHolder{
        ImageView imageView;
        TextView firstNameView, lastNameView;

        public MyViewHolder(@NonNull View itemView) {
            super(itemView);

            imageView = itemView.findViewById(R.id.imageView);
            firstNameView = itemView.findViewById(R.id.textView);
            lastNameView = itemView.findViewById(R.id.textView2);
        }
    }
}
