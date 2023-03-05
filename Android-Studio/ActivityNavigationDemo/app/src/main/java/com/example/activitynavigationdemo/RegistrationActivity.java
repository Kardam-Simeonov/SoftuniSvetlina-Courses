package com.example.activitynavigationdemo;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class RegistrationActivity extends AppCompatActivity {
    EditText username;
    EditText password;
    Button submitButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registration);
        username = findViewById(R.id.editTextUsername);
        password = findViewById(R.id.editTextPassword);
        submitButton = findViewById(R.id.submitButton);

        submitButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent startAddInfoScreen = new Intent(RegistrationActivity.this, AdditionalInformationActivity.class);
                startAddInfoScreen.putExtra("username", username.getText().toString());
                startActivity(startAddInfoScreen);
            }
        });
    }
}