using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace ConsoleApplication2
{
    public interface IStoreItem
    {
        double Price { get; set; }

        void DiscountPrice(int percent);
    }

    public class Disk : IStoreItem
    {
        protected string _name;
        protected string _genre;
        protected int _burnCount;

        public Disk(string name, string genre)
        {
            this._name = name;
            this._genre = genre;
        }

        public virtual int DiskSize { get ; set; }
        

        public virtual void Burn(params object[] values)
        {
        }
        
        public double Price { get; set; }
        
        public void DiscountPrice(int percent)
        {
            Price *= (1 - percent / 100);
        }
        
        public string Name()
        {
            return _name;
        }
    }

    public class Audio : Disk
    {
        private string _artist;
        private string _recordingStudio;
        private int _songsNumber;

        public Audio(string name, string genre, string artist, string recordingStudio, int songsNumber) :
            base(name, genre)
        {
            this._artist = artist;
            this._recordingStudio = recordingStudio;
            this._songsNumber = songsNumber;
        }

        public override int DiskSize {
            get { return (_songsNumber * 8); }
            set { _songsNumber = value; }
        }

    public override void Burn(params object[] values)
        {
            this._name = (string)values[0];
            this._genre = (string)values[1];
            this._artist = (string)values[2];
            this._recordingStudio = (string)values[3];
            this._songsNumber = (int)values[4];
            _burnCount++;
        }
        
        public override string ToString()
        {
            return $"Name: {_name}\nGenre: {_genre}\nArtist: {_artist}\nRecording studio: {_recordingStudio}\nNumber of songs: {_songsNumber}\nNumber of burns: {_burnCount}\n";
        }

        
    }

    public class DVD : Disk
    {
        private string _producer;
        private string _filmCompany;
        private int _minutesCount;

        
        public DVD(string name, string genre, string producer, string filmCompany, int minutesCount) :
            base(name, genre)
        {
        this._producer = producer;
        this._filmCompany = filmCompany;
        this._minutesCount = minutesCount;
        }
        
        public override int DiskSize
        {
            get { return (_minutesCount / 64) * 2;}
            set {}
        }
        
        public override void Burn(params object[] values)
        {
            this._name = (string)values[0];
            this._genre = (string)values[1];
            this._producer = (string)values[2];
            this._filmCompany = (string)values[3];
            this._minutesCount = (int)values[4];
            _burnCount++;
        }
        
        public override string ToString()
        {
            return $"Name: {_name}\nGenre: {_genre}\nArtist: {_producer}\nRecording studio: {_filmCompany}\nNumber of songs: {_minutesCount}\nNumber of burns: {_burnCount}";
        }
    }

    public class Store
    {
        private string _storeName;
        private string _storeAddress;
        private static List<Audio> _audios = new List<Audio>();
        private static List<DVD> _dvds = new List<DVD>();

        public Store(string storeName, string storeAddress, List<Audio> audios, List<DVD> dvds)
        {
            this._storeName = storeName;
            this._storeAddress = storeAddress;
            _audios = audios;
            _dvds = dvds;

        }

        public static Store operator +(Store store, Audio audio)
        {
           _audios.Add(audio);
           return store;
        }
        
        public static Store operator -(Store store, Audio audio)
        {
            _audios.Remove(audio);
            return store;
        }
        
        public static Store operator +(Store store, DVD dvd)
        {
            _dvds.Add(dvd);
            return store;
        }
        
        public static Store operator -(Store store, DVD dvd)
        {
            _dvds.Remove(dvd);
            return store;
        }
        
        public override string ToString()
        {
            Console.WriteLine($"Store name: {_storeName}\n");
            foreach (Audio audioInStore in _audios)
            {
                Console.WriteLine(audioInStore.ToString());

            }
            foreach (DVD dvdInStore in _dvds)
            {
                Console.WriteLine(dvdInStore.ToString());

            }

            return null;
        }

        public string AllDisks()
        {
            foreach (Audio diskFromStore in _audios)
            {
                Console.Write(diskFromStore.Name() + " -> ");
                Console.WriteLine(diskFromStore.DiskSize = diskFromStore.DiskSize);

            }
            
            foreach (DVD diskFromStore in _dvds)
            {
                Console.Write(diskFromStore.Name() + " -> ");
                Console.WriteLine(diskFromStore.DiskSize = diskFromStore.DiskSize);
            }

            return null;
        }
    }
}