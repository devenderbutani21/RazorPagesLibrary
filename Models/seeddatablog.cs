using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesLibrary.Data;
using System;

namespace razorpageslibrary.models
{
    public static class seeddatablog
    {
        public static void initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesLibraryContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesLibraryContext>>()))
            {
                if (context == null || context.BlogModel == null)
                {
                    throw new ArgumentNullException("Null RazorPageLibraryContext");
                }

                // Look for any books
                if (context.BlogModel.Any())
                {
                    return; // DB has been seeded
                }

                context.BlogModel.addrange(
                    new BlogModel
                    {
                        title = "unlock the world of your favorite books with kindle—a literary adventure awaits at your fingertips.",
                        date = DateTime.Parse("2023-12-24"),
                        readtime = 5,
                        description = "in a world where technology seamlessly intertwines with our daily lives, the way we experience literature has evolved. gone are the days of bulky bookshelves and heavy backpacks laden with novels. the kindle, a revolutionary e-reader, has ushered in a new era of literary exploration, offering a literary adventure at your fingertips. join us as we unlock the world of your favorite books and delve into the magic that kindle brings to avid readers.\r\n\r\nthe kindle has redefined the reading experience by providing unparalleled convenience. no longer bound by the constraints of physical books, you can carry an entire library in a sleek, lightweight device. whether you're commuting, traveling, or simply relaxing at home, your literary adventures are always within reach. the kindle allows you to access thousands of titles at the touch of a button, making it the perfect companion for every reader on the go.\r\n\r\nkindle opens the door to an expansive world of literature, offering a vast selection of e-books, magazines, and audiobooks. from classic novels to contemporary bestsellers, kindle's extensive library caters to diverse tastes and preferences. readers can explore new genres, discover hidden gems, and broaden their literary horizons with just a few clicks. the kindle store ensures that your next favorite read is always just a search away.\r\n\r\nkindle enhances the reading experience by putting you in control. with adjustable font sizes, background colors, and font styles, you can tailor your reading environment to suit your preferences. whether you prefer a classic black-and-white display or a warm, sepia-toned background, kindle allows you to create a personalized reading space that complements your style. the device even adapts to different lighting conditions, ensuring a comfortable reading experience day or night.\r\n\r\nkindle's whispersync technology seamlessly syncs your reading progress across devices. start a book on your kindle e-reader, continue on your smartphone during lunch, and pick up where you left off on your tablet before bed – all without losing your place. this feature ensures a smooth and uninterrupted literary journey, allowing you to immerse yourself in the narrative without any disruptions.\r\n\r\nfor the truly adventurous reader, kindle unlimited offers a subscription service that grants unlimited access to a vast selection of e-books and audiobooks. dive into a world of unlimited possibilities, exploring new authors and genres without any additional cost. kindle unlimited is a literary playground where your next great adventure is just waiting to be discovered.\r\n\r\nthe kindle has transformed the way we experience literature, unlocking a world of possibilities at our fingertips. convenience, variety, customization, and innovative technologies like whispersync make kindle a must-have companion for avid readers. embrace the literary adventure that awaits you with kindle, and let the pages come alive in the digital realm, ushering in a new era of reading pleasure. your next great read is just a click away – embark on your kindle journey today."
                    },

                    new BlogModel
                    {
                        title = "discover the must-read books of 2024, a diverse collection to captivate and inspire.",
                        date = DateTime.Parse("2023-12-28"),
                        readtime = 7,
                        description = "as we step into a new year, the literary world welcomes a fresh array of captivating and inspiring books. the literary landscape of 2024 promises to be rich and diverse, offering readers a plethora of stories that will transport them to different worlds, challenge their perspectives, and ignite their imaginations. join us on a journey through the must-read books of 2024 – a collection that spans genres, cultures, and themes, ensuring there's something for every reader.\r\n\r\n\"the luminous city\" by aisha patel:\r\naisha patel's debut novel, \"the luminous city,\" takes readers on a mesmerizing journey through the streets of a fictional metropolis where magic and technology coexist. with lush prose and a captivating storyline, patel weaves a tale of intrigue, love, and self-discovery that will leave readers spellbound.\r\n\r\n\"infinite horizons\" by javier moreno:\r\nmoreno's science fiction masterpiece, \"infinite horizons,\" explores the limitless possibilities of human potential. set in a future where interstellar travel is a reality, the novel delves into the moral and ethical dilemmas faced by explorers as they navigate uncharted territories. this thought-provoking tale challenges readers to contemplate the boundaries of human ambition.\r\n\r\n\"threads of time\" by mei ling:\r\nmei ling's historical fiction novel, \"threads of time,\" offers a vivid portrayal of a bygone era. set against the backdrop of a sweeping historical event, ling intricately weaves together the lives of diverse characters, bringing history to life with passion and authenticity. readers will be transported to a world where the threads of time connect us all.\r\n\r\n\"echoes of eternity\" by carlos ruiz:\r\ncarlos ruiz, known for his lyrical prose, delivers a poignant and beautifully crafted novel in \"echoes of eternity.\" this metaphysical exploration of life, death, and the interconnectedness of all things is a philosophical journey that will leave readers contemplating the profound mysteries of existence.\r\n\r\n\"a symphony of stars\" by olivia harper:\r\nolivia harper's \"a symphony of stars\" is a sweeping epic that spans galaxies, telling the story of love, sacrifice, and the enduring human spirit. with a diverse cast of characters and a plot that unfolds across celestial landscapes, harper's novel is a symphony of emotions that will resonate with readers long after they've turned the last page"
                    },

                    new BlogModel
                    {
                        title = "explore top book picks for 2024 by ceos, offering insights and inspiration for success.",
                        date = DateTime.Parse("2023-12-30"),
                        readtime = 9,
                        description = "in the fast-paced world of business, ceos are often seen as the trailblazers, visionaries, and leaders who shape the future. a glimpse into the reading lists of these influential figures can offer valuable insights into their mindset, strategies, and the knowledge they seek to propel themselves and their organizations forward. join us as we explore the top book picks for 2024 by ceos, providing a curated selection that promises insights and inspiration for success in the corporate world and beyond.\r\n\r\n\"the infinite game\" by simon sinek:\r\nsimon sinek's \"the infinite game\" is a perennial favorite among ceos for its profound exploration of leadership and business strategy. sinek challenges the traditional notion of business as a finite game with winners and losers, advocating for an infinite mindset that focuses on long-term success and adaptability. ceos appreciate sinek's thought-provoking ideas on building resilient organizations capable of thriving in an ever-changing landscape.\r\n\r\n\"range: why generalists triumph in a specialized world\" by david epstein:\r\ndavid epstein's \"range\" explores the advantages of being a generalist in a world that often celebrates specialization. ceos find inspiration in epstein's research-backed insights, which argue that a breadth of experiences and knowledge can lead to more innovative thinking and problem-solving. in a rapidly evolving business environment, \"range\" encourages leaders to embrace diverse skill sets and adaptability.\r\n\r\n\"no rules rules: netflix and the culture of reinvention\" by reed hastings and erin meyer:\r\nnetflix co-founder reed hastings, along with erin meyer, delves into the revolutionary company culture that transformed netflix into a global powerhouse. \"no rules rules\" offers a behind-the-scenes look at netflix's unconventional approach to talent management, innovation, and organizational culture. ceos find valuable lessons in this book on fostering a culture of creativity, freedom, and reinvention within their own companies.\r\n\r\n\"the art of impossible: a peak performance primer\" by steven kotler:\r\nsteven kotler's \"the art of impossible\" explores the science behind achieving the extraordinary. ceos are drawn to kotler's insights on peak performance, flow states, and the pursuit of ambitious goals. the book provides practical strategies for unlocking human potential and achieving feats that may initially seem impossible, making it a go-to resource for leaders aiming for greatness.\r\n\r\n\"the innovators: how a group of hackers, geniuses, and geeks created the digital revolution\" by walter isaacson:\r\nwalter isaacson's exploration of the digital revolution in \"the innovators\" is a compelling read for ceos seeking historical context and lessons from transformative innovators. isaacson chronicles the stories of key figures who shaped the technology landscape, offering valuable lessons on collaboration, vision, and adaptability in the face of technological disruption."
                    }
                    );
            }
        }
    }
}
