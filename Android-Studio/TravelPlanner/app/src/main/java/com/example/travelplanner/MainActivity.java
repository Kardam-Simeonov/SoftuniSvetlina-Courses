package com.example.travelplanner;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.app.ActivityCompat;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import androidx.swiperefreshlayout.widget.SwipeRefreshLayout;
import android.Manifest;


import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.location.Location;
import android.location.LocationManager;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MainActivity extends AppCompatActivity {

    private ArrayList<PlaceItemModel> placeItemModels = new ArrayList<>();
    private RecyclerView recyclerView;
    private Place_RecyclerViewAdapter adapter;
    private Toolbar toolbar;
    private Button favouritesButton;
    private SwipeRefreshLayout swipeRefreshLayout;
    private OpenTripMapApi openTripMapApi;

    private static final int REQUEST_LOCATION_PERMISSION = 1;
    private int radius = 50000;
    private double latitude = 42.6977;
    private double longitude = 23.3219;
    private String kinds = "interesting_places";
    private String apiKey = "5ae2e3f221c38a28845f05b66796cc3b951875c82a62eda365164c99";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        recyclerView = findViewById(R.id.RecyclerView);
        adapter = new Place_RecyclerViewAdapter(this, placeItemModels);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("https://api.opentripmap.com")
                .addConverterFactory(GsonConverterFactory.create())
                .build();
        openTripMapApi = retrofit.create(OpenTripMapApi.class);

        swipeRefreshLayout = findViewById(R.id.swipeRefreshLayout);
        swipeRefreshLayout.setOnRefreshListener(() -> fetchDataFromServer(radius, latitude, longitude, kinds, apiKey));

        LocationManager locationManager = (LocationManager) getSystemService(Context.LOCATION_SERVICE);
        if (ActivityCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION) == PackageManager.PERMISSION_GRANTED
                && locationManager.isProviderEnabled(LocationManager.GPS_PROVIDER)) {
            Location location = locationManager.getLastKnownLocation(LocationManager.GPS_PROVIDER);
            if (location != null) {
                latitude = location.getLatitude();
                longitude = location.getLongitude();
            } else {
                Toast.makeText(MainActivity.this, "Location is turned off", Toast.LENGTH_SHORT).show();
            }
        } else {
            ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.ACCESS_FINE_LOCATION}, REQUEST_LOCATION_PERMISSION);
        }

        fetchDataFromServer(radius, latitude, longitude, kinds, apiKey);

        recyclerView.setAdapter(adapter);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));

        toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        favouritesButton = findViewById(R.id.toolbar_favorites);
        favouritesButton.setOnClickListener(v -> {
            Intent intent = new Intent(MainActivity.this, FavouritesActivity.class);
            startActivity(intent);
        });
    }

    private void fetchDataFromServer(int radius, double latitude, double longitude, String kinds, String apiKey) {
        Call<PlacesResponse> call = openTripMapApi.getPlaces(radius, longitude, latitude, kinds, apiKey);
        call.enqueue(new Callback<PlacesResponse>() {
            @Override
            public void onResponse(Call<PlacesResponse> call, Response<PlacesResponse> response) {
                if (response.isSuccessful()) {
                    PlacesResponse placesResponse = response.body();

                    if (placesResponse != null) {
                        for (PlacesResponse.Feature feature : placesResponse.getFeatures()) {
                            String xId = feature.getProperties().getXid();
                            String name = feature.getProperties().getName();
                            String kinds = feature.getProperties().getKinds();

                            if (!TextUtils.isEmpty(xId) && !TextUtils.isEmpty(name) && !TextUtils.isEmpty(kinds)) {
                                String firstWord = kinds.split(",")[0];
                                PlaceItemModel placeItemModel = new PlaceItemModel(xId, name, firstWord);
                                placeItemModels.add(placeItemModel);
                            }
                        }

                        adapter.notifyDataSetChanged();
                    }
                } else {
                    Toast.makeText(MainActivity.this, "Error with fetching data", Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<PlacesResponse> call, Throwable t) {
                Toast.makeText(MainActivity.this, "Network error", Toast.LENGTH_SHORT).show();
            }
        });

        swipeRefreshLayout.setRefreshing(false);
    }
}
