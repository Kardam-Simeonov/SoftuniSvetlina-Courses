package com.example.travelplanner;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class Place_RecyclerViewAdapter extends RecyclerView.Adapter<Place_RecyclerViewAdapter.MyViewHolder> {
    Context context;
    ArrayList<PlaceItemModel> placeModels;

    public Place_RecyclerViewAdapter(Context context, ArrayList<PlaceItemModel> placeModels){
        this.context = context;
        this.placeModels = placeModels;
    }

    @NonNull
    @Override
    public Place_RecyclerViewAdapter.MyViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(context);
        View view = inflater.inflate(R.layout.recycler_view_row, parent, false);

        return new Place_RecyclerViewAdapter.MyViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull Place_RecyclerViewAdapter.MyViewHolder holder, int position) {
        holder.destinationName.setText(placeModels.get(position).getName());
        holder.destinationCategory.setText(placeModels.get(position).getKinds());

        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // Handle card click event
                String property = getItem(position).getProperty(); // Get the property from the clicked card

                // Create an Intent and pass the property as an extra
                Intent intent = new Intent(view.getContext(), AnotherActivity.class);
                intent.putExtra("PROPERTY_KEY", property);

                // Start the new activity
                view.getContext().startActivity(intent);
            }
        });
    }

    @Override
    public int getItemCount() {
        return placeModels.size();
    }

    public static class MyViewHolder extends RecyclerView.ViewHolder{
        TextView destinationName, destinationCategory;

        public MyViewHolder(@NonNull View itemView) {
            super(itemView);

            destinationName = itemView.findViewById(R.id.destinationNameTextView);
            destinationCategory = itemView.findViewById(R.id.destinationCategoryTextView);
        }
    }
}
