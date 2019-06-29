package com.example.habersitesi;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Details_News extends AppCompatActivity {

    int likeCount = 0,unlikeCount = 0;
    TextView like,body,tittle,unlike,data,displayed;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details_news);

         tittle = (TextView)findViewById(R.id.txtTittle);
         body = (TextView)findViewById(R.id.txtBody);
         like = (TextView)findViewById(R.id.txtlike);
         unlike = (TextView)findViewById(R.id.txtUnlike);
         data = (TextView)findViewById(R.id.txtData);
         displayed = (TextView)findViewById(R.id.txtdisplayed) ;

        tittle.setText(getIntent().getStringExtra("Tittle"));
        body.setText(getIntent().getStringExtra("body"));
        likeCount = Integer.valueOf(getIntent().getStringExtra("like"));
        data.setText(getIntent().getStringExtra("data"));
        displayed.setText(getIntent().getStringExtra("__v"));
        unlikeCount = Integer.valueOf(getIntent().getStringExtra("unlike"));

        Button btnLike = (Button)findViewById(R.id.btnlike);
        Button btnUnlike = (Button)findViewById(R.id.btnUnlike);


        btnLike.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View arg0) {

                likeCount = likeCount + 1;
                like.setText(Integer.toString(likeCount));
            }

        });
        like.setText(Integer.toString(likeCount));

        btnUnlike.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View arg0) {

                unlikeCount = unlikeCount + 1;
                unlike.setText(Integer.toString(unlikeCount));
            }
        });
        unlike.setText(Integer.toString(unlikeCount));

    }
}
