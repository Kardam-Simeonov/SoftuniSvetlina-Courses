package com.example.apifetching;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        TextView potionName = findViewById(R.id.name);
        TextView potionEffect = findViewById(R.id.effect);
        Button nextButton = findViewById(R.id.nextButton);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("https://wizard-world-api.herokuapp.com")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        ApiService api = retrofit.create(ApiService.class);

        Call<List<Elixir>> call = api.getElixirs(15);
        call.enqueue(new Callback<List<Elixir>>() {
            @Override
            public void onResponse(Call<List<Elixir>> call, Response<List<Elixir>> response) {
                if (response.isSuccessful()) {
                    List<Elixir> elixirs = (List<Elixir>) response.body();
                    int randomIndex = (int) (Math.random() * elixirs.size());
                    Elixir randomElixir = elixirs.get(randomIndex);

                    String name = randomElixir.getName();
                    String effect = randomElixir.getEffect();

                    potionName.setText(name);

                    if (effect == null)
                        potionEffect.setText("Unknown effect");
                    else
                        potionEffect.setText(effect);
                } else {
                    potionName.setText("Error in response");
                    potionEffect.setText("Error in response");
                }
            }

            @Override
            public void onFailure(Call<List<Elixir>> call, Throwable t) {
                potionName.setText("Network error");
                potionEffect.setText("Network Error");
            }
        });

        nextButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ApiService api = retrofit.create(ApiService.class);

                Call<List<Elixir>> call = api.getElixirs(20);
                call.enqueue(new Callback<List<Elixir>>() {
                    @Override
                    public void onResponse(Call<List<Elixir>> call, Response<List<Elixir>> response) {
                        if (response.isSuccessful()) {
                            List<Elixir> elixirs = (List<Elixir>) response.body();
                            int randomIndex = (int) (Math.random() * elixirs.size());
                            Elixir randomElixir = elixirs.get(randomIndex);

                            String name = randomElixir.getName();
                            String effect = randomElixir.getEffect();

                            potionName.setText(name);

                            if (effect == null)
                                potionEffect.setText("Unknown effect");
                            else
                            potionEffect.setText(effect);
                        } else {
                            potionName.setText("Error in response");
                            potionEffect.setText("Error in response");
                        }
                    }

                    @Override
                    public void onFailure(Call<List<Elixir>> call, Throwable t) {
                        potionName.setText("Network error");
                        potionEffect.setText("Network Error");
                    }
                });
            }
        });
    }
}