package com.example.travelplanner;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class Place_RecyclerViewAdapter extends RecyclerView.Adapter<Person_RecyclerViewAdapter.MyViewHolder> {
    Context context;
    ArrayList<PlaceItemModel> placeModels;

    public Place_RecyclerViewAdapter(Context context, ArrayList<PlaceItemModel> placeModels){
        this.context = context;
        this.placeModels = placeModels;
    }

    @NonNull
    @Override
    public Person_RecyclerViewAdapter.MyViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(context);
        View view = inflater.inflate(R.layout.recycler_view_row, parent, false);

        return new Place_RecyclerViewAdapter.MyViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull Person_RecyclerViewAdapter.MyViewHolder holder, int position) {

    }

    @Override
    public int getItemCount() {
        return 0;
    }
}
