using System;
using System.Collections.Generic;
using Android.Views;
using Android.Widget;
using WorklabsMx.Droid.ViewHolders;
using WorklabsMx.Models;

namespace WorklabsMx.Droid.Helpers
{
    public class PostListAdapter : BaseAdapter<PostModel>
    {
        readonly List<PostModel> posts;
        public PostListAdapter(List<PostModel> posts) => this.posts = posts;

        public override PostModel this[int position] => posts[position];

        public override int Count => posts.Count;

        public override long GetItemId(int position) => (long)Convert.ToDouble(posts[position].Publicacion_Id);

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.PostLayout, parent, false);

            }

            PostHolder holder = (PostHolder)view.Tag;

            return view;
        }

        public void UpdatePosts(List<PostModel> posts)
        {
            this.posts.AddRange(posts);
        }
    }
}
