package com.example.travelplanner;

import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class FavouritesActivity extends AppCompatActivity {
    private ArrayList<PlaceItemModel> placeItemModels = new ArrayList<>();
    private RecyclerView recyclerView;
    private TextView placeholderTextView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_favourites);

        recyclerView = findViewById(R.id.RecyclerView);
        placeholderTextView = findViewById(R.id.placeholderTextView);

        Place_RecyclerViewAdapter adapter = new Place_RecyclerViewAdapter(this, placeItemModels);
        recyclerView.setAdapter(adapter);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        Button backButton = findViewById(R.id.toolbar_back);
        backButton.setOnClickListener(v -> onBackPressed());

        // Retrieve places from the database
        AppDatabase database = AppDatabase.getInstance(getApplicationContext());
        PlaceDao placeDao = database.placeDao();
        List<Place> places = placeDao.getAllPlaces();

        // Populate placeItemModels with retrieved places
        for (Place place : places) {
            PlaceItemModel placeItemModel = new PlaceItemModel(place.getXid(), place.getName(), place.getKinds());
            placeItemModels.add(placeItemModel);
        }

        // Notify the adapter that data has changed
        adapter.notifyDataSetChanged();

        // Show/hide placeholder TextView based on the number of records
        placeholderTextView.setVisibility(places.isEmpty() ? View.VISIBLE : View.GONE);
    }
}

