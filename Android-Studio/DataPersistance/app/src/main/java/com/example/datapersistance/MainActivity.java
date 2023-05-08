package com.example.datapersistance;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MainActivity extends AppCompatActivity {

    public EditText barcodeInput;
    public Button searchButton;

    private ProductService productService;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl("https://world.openfoodfacts.org/api/v0/")
                .addConverterFactory(GsonConverterFactory.create())
                .build();

        productService = retrofit.create(ProductService.class);

        barcodeInput = findViewById(R.id.barcode_input);
        searchButton = findViewById(R.id.lookup_button);

        searchButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String barcode = barcodeInput.getText().toString();
                Product product = (Product) AppDatabase.getInstance(MainActivity.this).productDao().getProductByCode(barcode);

                if (product != null){
                    // Display information
                } else {
                    Call<ProductResponse> call = productService.getProductByBarcode(barcode);
                    call.enqueue(new Callback<ProductResponse>() {
                        @Override
                        public void onResponse(Call<ProductResponse> call, Response<ProductResponse> response) {
                            if (response.isSuccessful()) {
                                ProductResponse productResponse = response.body();
                                Product product = new Product(barcode, productResponse.getName(), productResponse.getIngredients());

                                AppDatabase.getInstance(MainActivity.this).productDao().insertProduct(product);

                                // Display product information to user
                            } else {
                                // Handle network error

                            }
                        }

                        @Override
                        public void onFailure(Call<ProductResponse> call, Throwable t) {
                            // Handle network error
                        }
                    }
                }
            }
        });
    }
}