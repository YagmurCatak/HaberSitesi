package com.example.habersitesi;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.support.v7.app.AppCompatActivity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.Toast;

import com.google.gson.Gson;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class EducationFragment extends Fragment {

    ArrayList<News> Haberler ;
    ArrayList<News> yeniliste  ;
    List<News> news1;
    ListView listView;
    private static Adapter adapter;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

        //listenin olduğu syfa
        View view = inflater.inflate(R.layout.education_fragment, container, false);
        listView = (ListView) getActivity().findViewById(R.id.listviewEducation);

        return view;
    }

    @Override
    public void onActivityCreated(@Nullable Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);

        listView = (ListView) getActivity().findViewById(R.id.listviewEducation);

        Haberler = new ArrayList<>();

        Service s = new Service();
        String haber = s.doInBackground();
        news1 = new ArrayList<>();

        if (null != haber) {
            //Timber.i("jsonData null değil ..");
            Gson gson = new Gson();

            news1 = Arrays.asList(gson.fromJson(haber,News[].class));

            for (int i = 0; i < news1.size(); i++) {
              Haberler.add(new News(news1.get(i).id,news1.get(i).picturePath,news1.get(i).tittle,news1.get(i).body,news1.get(i).type,news1.get(i).data,news1.get(i).like,news1.get(i).unlike,news1.get(i).displayed)) ;
            }
        }
        //Haberler.add(new News(1, "C:\\Users\\yagmur\\Desktop\\yazlab\\resim2", "EGİTİM", haber, "egitim", "11.2.2009", 3, 5, 78));
        //Haberler.add(new News(2, "C:\\Users\\yagmur\\Desktop\\yazlab\\resim2", "EKONOMİ", "yeşillik", "ekonomi", "11.2.2009", 3, 5, 78));
        //Haberler.add(new News(3, "C:\\Users\\yagmur\\Desktop\\yazlab\\resim2", "BEŞİKTAŞ ŞAMPİYON", "yeşillik", "spor", "11.2.2009", 3, 5, 78));

        yeniliste = new ArrayList<>();
        for (int i = 0; i < Haberler.size(); i++) {
            if (Haberler.get(i).type.contains("egitim")) {
                yeniliste.add(Haberler.get(i));
            }
        }

        adapter = new com.example.habersitesi.HaberlerAdapter(yeniliste, getActivity(), getContext());
        listView.setAdapter((ListAdapter) adapter);

        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> parent, View view,
                                    int position, long id) {

                Intent veri = new Intent(getActivity(),Details_News.class);
                veri.putExtra("body", yeniliste.get(position).body);
                veri.putExtra("data",yeniliste.get(position).data);
                veri.putExtra("like",yeniliste.get(position).like);
                veri.putExtra("unlike",yeniliste.get(position).unlike);
                veri.putExtra("picturePath",yeniliste.get(position).picturePath);
                veri.putExtra("Tittle",yeniliste.get(position).tittle);
                int displayed = Integer.valueOf(yeniliste.get(position).displayed) + 1;
                veri.putExtra("__v",Integer.toString(displayed));
                startActivity(veri);
            }
        });
    }
}