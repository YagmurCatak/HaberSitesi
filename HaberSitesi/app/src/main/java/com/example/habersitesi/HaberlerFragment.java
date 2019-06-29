package com.example.habersitesi;

import android.content.Intent;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.ListAdapter;
import android.widget.ListView;

import com.google.gson.Gson;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class HaberlerFragment extends Fragment {

    ArrayList<News> Haberler ;
    List<News> news1;
    ListView listView;
    private static Adapter adapter;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

        //listenin olduğu syfa
        View view = inflater.inflate(R.layout.news_fragment, container, false);

        return view;
    }

    @Override
    public void onActivityCreated(@Nullable Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);

        listView = (ListView) getActivity().findViewById(R.id.listviewHaberler);

        Haberler = new ArrayList<>();
        Service s = new Service();
        String haber = s.doInBackground();
        try{
            if (null != haber) {
                //Timber.i("jsonData null değil ..");
                Gson gson = new Gson();

                news1 = new ArrayList<>();
                news1 = Arrays.asList(gson.fromJson(haber,News[].class));

                for (int i = 0; i < news1.size(); i++) {
                    Haberler.add(new News(news1.get(i).id,news1.get(i).picturePath,news1.get(i).tittle,news1.get(i).body,news1.get(i).type,news1.get(i).data,news1.get(i).like,news1.get(i).unlike,news1.get(i).displayed)) ;
                }
            }
        }catch (Exception ex){}

        adapter = new com.example.habersitesi.HaberlerAdapter(Haberler, getActivity(), getContext());
        listView.setAdapter((ListAdapter) adapter);

        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> parent, View view,
                                    int position, long id) {

                Intent veri = new Intent(getActivity(),Details_News.class);
                veri.putExtra("body", Haberler.get(position).body);
                veri.putExtra("data",Haberler.get(position).data);
                veri.putExtra("like",Haberler.get(position).like);
                veri.putExtra("unlike",Haberler.get(position).unlike);
                veri.putExtra("picturePath",Haberler.get(position).picturePath);
                veri.putExtra("Tittle",Haberler.get(position).tittle);
                int displayed = Integer.valueOf(Haberler.get(position).displayed) + 1;
                veri.putExtra("__v",Integer.toString(displayed));
                startActivity(veri);
            }
        });
    }
}

