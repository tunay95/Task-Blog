using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Exam
{
    static class BlogService
    {

        public static void AddBlog(Blog blog)
        {
            BlogDatabase.Blogs.Add(blog);
            
        }


        public static void RemoveBlog(int id)
        {
            BlogDatabase.Blogs.Remove(GetBlogById(id));
            

        }

        public static Blog GetBlogById(int id)
        {

            Blog FoundBlog = null;
            FoundBlog = BlogDatabase.Blogs.FirstOrDefault(b => b.Id == id);
            if (FoundBlog != null)
            {
                return FoundBlog;

            }
            else
            {

                throw new BlogNotFoundException("Blog not Found");
            }
        }

        public static void GetAllBlogs(int id)
        {
            foreach (Blog item in Blogs)
            {
                Console.WriteLine(item.Name);
            }

        }

        public static void GetBlogsByValue(string value)
        {



        }

    }
}
