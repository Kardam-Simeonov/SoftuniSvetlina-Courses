package com.example.travelplanner;

import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import com.bumptech.glide.Glide;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class DetailsActivity extends AppCompatActivity {
    private ImageView imageView;
    private TextView paragraphTextView;
    private Button addToFavoritesButton;

    private PlaceDetailsResponse placeDetails;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details);

        String xID = getIntent().getStringExtra("xID");

        imageView = findViewById(R.id.imageView);
        paragraphTextView = findViewById(R.id.paragraphTextView);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("https://api.opentripmap.com/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        OpenTripMapApi api = retrofit.create(OpenTripMapApi.class);
        Call<PlaceDetailsResponse> call = api.getPlaceDetails(xID, "5ae2e3f221c38a28845f05b66796cc3b951875c82a62eda365164c99");
        call.enqueue(new Callback<PlaceDetailsResponse>() {
            @Override
            public void onResponse(Call<PlaceDetailsResponse> call, Response<PlaceDetailsResponse> response) {
                if (response.isSuccessful()) {
                    placeDetails = response.body();
                    if (placeDetails != null) {
                        loadImage();
                        setParagraphText();
                    }
                } else {
                    Toast.makeText(DetailsActivity.this, "Error with fetching data", Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<PlaceDetailsResponse> call, Throwable t) {
                Toast.makeText(DetailsActivity.this, "Network Error", Toast.LENGTH_SHORT).show();
            }
        });

        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        Button backButton = findViewById(R.id.toolbar_back);
        backButton.setOnClickListener(v -> onBackPressed());

        addToFavoritesButton = findViewById(R.id.btnAddToFavorites);
        addToFavoritesButton.setOnClickListener(v -> addToFavorites(xID));
    }

    private void loadImage() {
        if (!TextUtils.isEmpty(placeDetails.getImageUrl())) {
            Glide.with(this)
                    .load(placeDetails.getImageUrl())
                    .into(imageView);
        } else {
            imageView.setImageResource(R.drawable.placeholder);
        }
    }

    private void setParagraphText() {
        if (!TextUtils.isEmpty(placeDetails.getParagraph())) {
            paragraphTextView.setText(placeDetails.getParagraph());
        } else {
            paragraphTextView.setText("This item doesn't have a description.");
        }
    }

    private void addToFavorites(String xID) {
        Place place = new Place(xID, placeDetails.getName(), placeDetails.getKinds().split(",")[0]);
        AppDatabase database = AppDatabase.getInstance(getApplicationContext());
        Place existingPlace = database.placeDao().getPlaceById(xID);
        if (existingPlace == null) {
            database.placeDao().insertPlace(place);
            Toast.makeText(DetailsActivity.this, "Added to favorites", Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(DetailsActivity.this, "Already added to favorites", Toast.LENGTH_SHORT).show();
        }
    }
}

