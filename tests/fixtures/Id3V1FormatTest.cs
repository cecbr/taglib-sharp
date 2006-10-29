using System;
using NUnit.Framework;

namespace TagLib
{   
    [TestFixture]
    public class Id3V1FormatTest
    {
        private File file;
        
        [TestFixtureSetUp]
        public void Init()
        {
            file = File.Create("samples/sample_v1_only.mp3");
        }
    
        [Test]
        public void ReadAudioProperties()
        {
            Assert.AreEqual(44100, file.AudioProperties.SampleRate);
            Assert.AreEqual(1, file.AudioProperties.Duration.Seconds);
        }
        
        [Test]
        public void ReadTags()
        {
            Assert.AreEqual("MP3 album", file.Tag.Album);
            Assert.AreEqual("MP3 artist", file.Tag.FirstArtist);
            Assert.AreEqual("MP3 comment", file.Tag.Comment);
            Assert.AreEqual("Acid Punk", file.Tag.FirstGenre);
            Assert.AreEqual("MP3 title", file.Tag.Title);
            Assert.AreEqual(6, file.Tag.Track);
            Assert.AreEqual(1234, file.Tag.Year);
        }
    }
}