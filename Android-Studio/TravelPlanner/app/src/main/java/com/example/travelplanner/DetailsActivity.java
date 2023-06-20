package com.example.travelplanner;

import android.os.Bundle;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import com.bumptech.glide.Glide;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class DetailsActivity extends AppCompatActivity {
    private ImageView imageView;
    private TextView paragraphTextView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details);

        // Get the xID from the Intent
        String xID = getIntent().getStringExtra("xID");

        // Initialize views
        imageView = findViewById(R.id.imageView);
        paragraphTextView = findViewById(R.id.paragraphTextView);

        // Make API request
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
                    // Retrieve the place details from the response
                    PlaceDetailsResponse placeDetails = response.body();
                    if (placeDetails != null) {
                        // Set the image using Glide library
                        Glide.with(DetailsActivity.this)
                                .load(placeDetails.getImageUrl())
                                .into(imageView);

                        // Set the paragraph text
                        paragraphTextView.setText(placeDetails.getParagraph());
                    }
                } else {
                    // Handle unsuccessful API request
                }
            }

            @Override
            public void onFailure(Call<PlaceDetailsResponse> call, Throwable t) {
                // Handle API request failure
            }
        });
    }
}
