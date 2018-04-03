using WordPress.RestClient;

namespace WordPress.Framework.RestCalls
{
    public static class PostCalls
    {
        public static void CreatePost(string title, string body) {
            Post post = new Post();
            post.title = title;
            post.content = body;

            RestClientManager.Instance.Create("posts", post);
        }
    }
}
