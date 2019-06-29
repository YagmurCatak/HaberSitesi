package com.example.habersitesi;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.habersitesi.News;
import com.example.habersitesi.R;

import org.w3c.dom.Text;

import java.util.ArrayList;
import java.util.List;

public class HaberlerAdapter extends ArrayAdapter<News> {

    private ArrayList<News> dataSet;
    Context mContext;
    Activity activity;

    private static class ViewHolder{
        ImageView image;
        TextView Title;
    }

    public HaberlerAdapter(ArrayList<News> data, Activity activity, Context context) {
        super(context, R.layout.home_page, data);
        this.dataSet = data;
        this.mContext=context;
        this.activity=activity;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent)
    {
        News Haberler = getItem(position);
        ViewHolder viewHolder;


        if(convertView == null)
        {
            viewHolder = new ViewHolder();
            LayoutInflater inflater = LayoutInflater.from(getContext());
            convertView = inflater.inflate(R.layout.home_page, parent, false);

            viewHolder.Title = (TextView) convertView.findViewById(R.id.txtName);
            viewHolder.image = (ImageView) convertView.findViewById(R.id.imgNews);
            convertView.setTag(viewHolder);
        }
        else
        {
            viewHolder = (ViewHolder) convertView.getTag();

        }

        viewHolder.Title.setText(Haberler.getTittle());


        return convertView;
    }


}