package com.example.datapersistance;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MainActivity extends AppCompatActivity {

    public EditText barcodeInput;

    public TextView productCode;
    public TextView productName;
    public TextView productIngredients;

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
        productCode = findViewById(R.id.product_code);
        productName = findViewById(R.id.product_name);
        productIngredients = findViewById(R.id.product_ingredients);
        searchButton = findViewById(R.id.lookup_button);

        searchButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String barcode = barcodeInput.getText().toString();
                List<Product> products = AppDatabase.getInstance(MainActivity.this).productDao().getProductByCode(barcode);

                if (!products.isEmpty()){
                    Product product = products.get(0);

                    // Display information
                    productCode.setText(product.getCode());
                    productName.setText(product.getName());
                    productIngredients.setText(product.getIngredients());
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
                                productCode.setText(product.getCode());
                                productName.setText(product.getName());
                                productIngredients.setText(product.getIngredients());
                            } else {
                                // Handle network error
                                productCode.setText("Network error");
                                productName.setText("Network error");
                                productIngredients.setText("Network error");
                            }
                        }

                        @Override
                        public void onFailure(Call<ProductResponse> call, Throwable t) {
                            // Handle network error
                            productCode.setText("Network error");
                            productName.setText("Network error");
                            productIngredients.setText("Network error");
                        }
                    });
                }
            }
        });
    }
}