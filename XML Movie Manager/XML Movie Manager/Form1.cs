using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Windows.Forms.VisualStyles;

namespace XML_Movie_Manager
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// 
        /// XML Movie Manager [Project 03]
        /// By: Frederik Blais
        /// 
        /// This class gives implements XML files reading and writing
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            readXMLFile("movies.xml");

            GetGenre();
        }

        /// <summary>
        ///             [ TO DO ]
        /// </summary>
        /// <param name="filePath"></param>
        /// 

        List<Movie> movieList = new List<Movie>();

        private void readXMLFile(string filePath)
        {
            Movie currentMovie;

            if (File.Exists(filePath))
            {
                // Create instance of XmlTextReader and call Read method to read file.
                XmlTextReader xmlReader = new XmlTextReader(filePath);

                // Move the first 'Movie' node in the XML file.
                xmlReader.ReadToFollowing("movie");

                do
                {
                    // Create a new 'Movie' object 
                    currentMovie = new Movie();


                    //----- GENRE ------

                    // Place the xmlReader at the 'genre' attribute of the current 'movie' node
                    xmlReader.MoveToFirstAttribute();

                    // Take the value of the 'genre' attribute and assign it to the currentMovie.Genre
                    currentMovie.Genre = xmlReader.Value;


                    //----- TITLE ------

                    // Place the xmlReader at the 'title' tag of the current 'movie' node
                    xmlReader.ReadToFollowing("title");

                    // Take the text value of the 'title' tag content and assign it to the currentBook.Title
                    currentMovie.Title = xmlReader.ReadElementContentAsString();


                    //----- YEAR ------

                    // Place the xmlReader at the 'author' tag of the current 'movie' node
                    xmlReader.ReadToFollowing("year");

                    // Take the text value of the 'year' tag and assign it to the currentMovie.Year
                    currentMovie.Year = Int32.Parse(xmlReader.ReadElementContentAsString());


                    //----- LENGTH ------

                    // Place the xmlReader at the 'length' tag of the current 'movie' node
                    xmlReader.ReadToFollowing("length");

                    // Take the text value of the 'year' tag and assign it to the currentMovie.Length
                    currentMovie.Length = xmlReader.ReadElementContentAsString();


                    //----- DIRECTOR ------

                    // Place the xmlReader at the 'director' tag of the current 'movie' node
                    xmlReader.ReadToFollowing("director");

                    // Take the text value of the 'year' tag and assign it to the currentMovie.Director
                    currentMovie.Director = xmlReader.ReadElementContentAsString();


                    //----- RATING ------

                    // Place the xmlReader at the 'audienceRating' tag of the current 'movie' node
                    xmlReader.ReadToFollowing("audienceRating");

                    // Take the text value of the 'audienceRating' tag and assign it to the currentMovie.Rating
                    currentMovie.Rating = xmlReader.ReadElementContentAsString();


                    //----- FILEPATH ------

                    // Place the xmlReader at the 'imageFilePath' tag of the current 'movie' node
                    xmlReader.ReadToFollowing("imageFilePath");

                    // Take the text value of the 'imageFilePath' tag and assign it to the currentMovie.FilePath
                    currentMovie.FilePath = xmlReader.ReadElementContentAsString();

                    try
                    {
                        imageList1.Images.Add(Image.FromFile(currentMovie.FilePath));
                    }
                    catch
                    {
                        MessageBox.Show("Your image path is invalid, please delete the previously added movies.");
                    }

                    // Add the current Movie to the movieList
                    movieList.Add(currentMovie);
                    movieListBox.Items.Add(currentMovie.Title);


                } while (xmlReader.ReadToFollowing("movie")); // Move to the next 'movie' node in the XML file

                // Close the xmlReader
                xmlReader.Close();

            }
            else
            {
                MessageBox.Show("The file "+filePath+" does not exists.");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            appendNodeToXMLFile("movies.xml");

            movieListBox.Items.Clear();

            readXMLFile("movies.xml");

            // Clear textboxes
            addGenreTextBox.Text = "";
            addTitleTextBox.Text = "";
            addYearTextBox.Text = "";
            addLengthTextBox.Text = "";
            addDirectorTextBox.Text = "";
            addRatingTextBox.Text = "";
            addPathTextBox.Text = "";

            // Set focus
            addGenreTextBox.Focus();
        }

        /// <summary>
        /// 
        /// Add new node to the root element with the fetched data of Form1.
        /// At the end, this method saves the new version of the XML Document to its correspondingXML File
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        private void appendNodeToXMLFile(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists(filePath))
            {
                // Load the xml file root element in memory
                xmlDoc.Load(filePath);

                // Create the XML File root element in memory
                XmlElement rootNode = xmlDoc.DocumentElement;

                // Create one XML for each node representing a new movie entry 
                XmlElement newMovieNode = xmlDoc.CreateElement("movie");
                XmlElement newTitleNode = xmlDoc.CreateElement("title");
                XmlElement newYearNode = xmlDoc.CreateElement("year");
                XmlElement newLengthNode = xmlDoc.CreateElement("length");
                XmlElement newDirectorNode = xmlDoc.CreateElement("director");
                XmlElement newRatingNode = xmlDoc.CreateElement("audienceRating");
                XmlElement newFilePathNode = xmlDoc.CreateElement("imageFilePath");

                // Create a TextNode element to assign the content to each node in the movie entry
                XmlText newTextNode;


                // --- TITLE ---

                // Assign a value for the 'category' attribute of the 'book' node
                newMovieNode.SetAttribute("genre",addGenreTextBox.Text);

                // Create the content for the 'title' node
                newTextNode = xmlDoc.CreateTextNode(addTitleTextBox.Text);

                // Add the content to the 'title' node
                newTitleNode.AppendChild(newTextNode);


                // --- YEAR ---

                // Create the content for the 'Year' node
                newTextNode = xmlDoc.CreateTextNode(addYearTextBox.Text);

                // Add the content to the 'Year' node
                newYearNode.AppendChild(newTextNode);


                // --- LENGTH ---

                // Create the content for the 'Length' node
                newTextNode = xmlDoc.CreateTextNode(addLengthTextBox.Text);

                // Add the content to the 'Length' node
                newLengthNode.AppendChild(newTextNode);


                // --- DIRECTOR ---

                // Create the content for the 'Director' node
                newTextNode = xmlDoc.CreateTextNode(addDirectorTextBox.Text);

                // Add the content to the 'Director' node
                newDirectorNode.AppendChild(newTextNode);


                // --- RATING ---

                // Create the content for the 'Rating' node
                newTextNode = xmlDoc.CreateTextNode(addRatingTextBox.Text);

                // Add the content to the 'Rating' node
                newRatingNode.AppendChild(newTextNode);


                // --- PATH ---

                // Create the content for the 'FilePath' node
                newTextNode = xmlDoc.CreateTextNode(addPathTextBox.Text);

                // Add the content to the 'FilePath' node
                newFilePathNode.AppendChild(newTextNode);


                // Append each 'child' node to the 'movie' node 
                newMovieNode.AppendChild(newTitleNode);
                newMovieNode.AppendChild(newYearNode);
                newMovieNode.AppendChild(newLengthNode);
                newMovieNode.AppendChild(newDirectorNode);
                newMovieNode.AppendChild(newRatingNode);
                newMovieNode.AppendChild(newFilePathNode);

                // Append the 'movie' node to the root ('movies') node
                rootNode.AppendChild(newMovieNode);

                // Save the updated version of the xmlDocument to the file
                xmlDoc.Save(filePath);
            }
            else
            {
                MessageBox.Show("The file " + filePath + " does not exists.");
            }
        }

        private void GetGenre()
        {
            genreListBox.Items.Clear();

            foreach (Movie movie in movieList)
            {
                if (!genreListBox.Items.Contains(movie.Genre))
                {
                    genreListBox.Items.Add(movie.Genre);
                }
            }
        }

        private void genreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            movieListBox.Items.Clear();

            string selection = genreListBox.SelectedItem.ToString();

            foreach(Movie movie in movieList)
            {
                if (movie.Genre == selection)
                {
                    movieListBox.Items.Add(movie.Title);
                }

            }
        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedMovie = movieListBox.SelectedItem.ToString();

                foreach(Movie movie in movieList)
                {
                    if(movie.Title == selectedMovie)
                    {
                        titleLabel.Text = movie.Title;
                        yearLabel.Text = movie.Year.ToString();
                        lengthLabel.Text = movie.Length;
                        directorLabel.Text = movie.Director;
                        ratingLabel.Text = movie.Rating;

                        int imageIndex = movieList.FindIndex(a => a.Title == selectedMovie);
                        pictureBox1.Image = imageList1.Images[imageIndex];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
