﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MovieDatabase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGenre(Genre instance);
    partial void UpdateGenre(Genre instance);
    partial void DeleteGenre(Genre instance);
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertMovie(Movie instance);
    partial void UpdateMovie(Movie instance);
    partial void DeleteMovie(Movie instance);
    partial void InsertMovieGenre(MovieGenre instance);
    partial void UpdateMovieGenre(MovieGenre instance);
    partial void DeleteMovieGenre(MovieGenre instance);
    partial void InsertMoviePerson(MoviePerson instance);
    partial void UpdateMoviePerson(MoviePerson instance);
    partial void DeleteMoviePerson(MoviePerson instance);
    partial void InsertPerson(Person instance);
    partial void UpdatePerson(Person instance);
    partial void DeletePerson(Person instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApplication1.Properties.Settings.Default.MovieDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Genre> Genres
		{
			get
			{
				return this.GetTable<Genre>();
			}
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<Movie> Movies
		{
			get
			{
				return this.GetTable<Movie>();
			}
		}
		
		public System.Data.Linq.Table<MovieGenre> MovieGenres
		{
			get
			{
				return this.GetTable<MovieGenre>();
			}
		}
		
		public System.Data.Linq.Table<MoviePerson> MoviePersons
		{
			get
			{
				return this.GetTable<MoviePerson>();
			}
		}
		
		public System.Data.Linq.Table<Person> Persons
		{
			get
			{
				return this.GetTable<Person>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Genre")]
	public partial class Genre : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type;
		
		private EntitySet<MovieGenre> _MovieGenres;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    #endregion
		
		public Genre()
		{
			this._MovieGenres = new EntitySet<MovieGenre>(new Action<MovieGenre>(this.attach_MovieGenres), new Action<MovieGenre>(this.detach_MovieGenres));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genre_MovieGenre", Storage="_MovieGenres", ThisKey="Id", OtherKey="genreID")]
		public EntitySet<MovieGenre> MovieGenres
		{
			get
			{
				return this._MovieGenres;
			}
			set
			{
				this._MovieGenres.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_MovieGenres(MovieGenre entity)
		{
			this.SendPropertyChanging();
			entity.Genre = this;
		}
		
		private void detach_MovieGenres(MovieGenre entity)
		{
			this.SendPropertyChanging();
			entity.Genre = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Role")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _type;
		
		private EntitySet<MoviePerson> _MoviePersons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    #endregion
		
		public Role()
		{
			this._MoviePersons = new EntitySet<MoviePerson>(new Action<MoviePerson>(this.attach_MoviePersons), new Action<MoviePerson>(this.detach_MoviePersons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_MoviePerson", Storage="_MoviePersons", ThisKey="Id", OtherKey="roleID")]
		public EntitySet<MoviePerson> MoviePersons
		{
			get
			{
				return this._MoviePersons;
			}
			set
			{
				this._MoviePersons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_MoviePersons(MoviePerson entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_MoviePersons(MoviePerson entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movie")]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _title;
		
		private int _releaseyear;
		
		private string _language;
		
		private double _length;
		
		private System.Nullable<int> _directorId;
		
		private EntitySet<MovieGenre> _MovieGenres;
		
		private EntitySet<MoviePerson> _MoviePersons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnreleaseyearChanging(int value);
    partial void OnreleaseyearChanged();
    partial void OnlanguageChanging(string value);
    partial void OnlanguageChanged();
    partial void OnlengthChanging(double value);
    partial void OnlengthChanged();
    partial void OndirectorIdChanging(System.Nullable<int> value);
    partial void OndirectorIdChanged();
    #endregion
		
		public Movie()
		{
			this._MovieGenres = new EntitySet<MovieGenre>(new Action<MovieGenre>(this.attach_MovieGenres), new Action<MovieGenre>(this.detach_MovieGenres));
			this._MoviePersons = new EntitySet<MoviePerson>(new Action<MoviePerson>(this.attach_MoviePersons), new Action<MoviePerson>(this.detach_MoviePersons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_releaseyear", DbType="Int NOT NULL")]
		public int releaseyear
		{
			get
			{
				return this._releaseyear;
			}
			set
			{
				if ((this._releaseyear != value))
				{
					this.OnreleaseyearChanging(value);
					this.SendPropertyChanging();
					this._releaseyear = value;
					this.SendPropertyChanged("releaseyear");
					this.OnreleaseyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_language", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string language
		{
			get
			{
				return this._language;
			}
			set
			{
				if ((this._language != value))
				{
					this.OnlanguageChanging(value);
					this.SendPropertyChanging();
					this._language = value;
					this.SendPropertyChanged("language");
					this.OnlanguageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_length", DbType="Float NOT NULL")]
		public double length
		{
			get
			{
				return this._length;
			}
			set
			{
				if ((this._length != value))
				{
					this.OnlengthChanging(value);
					this.SendPropertyChanging();
					this._length = value;
					this.SendPropertyChanged("length");
					this.OnlengthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_directorId", DbType="Int")]
		public System.Nullable<int> directorId
		{
			get
			{
				return this._directorId;
			}
			set
			{
				if ((this._directorId != value))
				{
					this.OndirectorIdChanging(value);
					this.SendPropertyChanging();
					this._directorId = value;
					this.SendPropertyChanged("directorId");
					this.OndirectorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_MovieGenre", Storage="_MovieGenres", ThisKey="Id", OtherKey="movieID")]
		public EntitySet<MovieGenre> MovieGenres
		{
			get
			{
				return this._MovieGenres;
			}
			set
			{
				this._MovieGenres.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_MoviePerson", Storage="_MoviePersons", ThisKey="Id", OtherKey="movieID")]
		public EntitySet<MoviePerson> MoviePersons
		{
			get
			{
				return this._MoviePersons;
			}
			set
			{
				this._MoviePersons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_MovieGenres(MovieGenre entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_MovieGenres(MovieGenre entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
		
		private void attach_MoviePersons(MoviePerson entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_MoviePersons(MoviePerson entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MovieGenre")]
	public partial class MovieGenre : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _movieID;
		
		private int _genreID;
		
		private EntityRef<Genre> _Genre;
		
		private EntityRef<Movie> _Movie;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnmovieIDChanging(int value);
    partial void OnmovieIDChanged();
    partial void OngenreIDChanging(int value);
    partial void OngenreIDChanged();
    #endregion
		
		public MovieGenre()
		{
			this._Genre = default(EntityRef<Genre>);
			this._Movie = default(EntityRef<Movie>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_movieID", DbType="Int NOT NULL")]
		public int movieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((this._movieID != value))
				{
					if (this._Movie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("movieID");
					this.OnmovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_genreID", DbType="Int NOT NULL")]
		public int genreID
		{
			get
			{
				return this._genreID;
			}
			set
			{
				if ((this._genreID != value))
				{
					if (this._Genre.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OngenreIDChanging(value);
					this.SendPropertyChanging();
					this._genreID = value;
					this.SendPropertyChanged("genreID");
					this.OngenreIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Genre_MovieGenre", Storage="_Genre", ThisKey="genreID", OtherKey="Id", IsForeignKey=true)]
		public Genre Genre
		{
			get
			{
				return this._Genre.Entity;
			}
			set
			{
				Genre previousValue = this._Genre.Entity;
				if (((previousValue != value) 
							|| (this._Genre.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Genre.Entity = null;
						previousValue.MovieGenres.Remove(this);
					}
					this._Genre.Entity = value;
					if ((value != null))
					{
						value.MovieGenres.Add(this);
						this._genreID = value.Id;
					}
					else
					{
						this._genreID = default(int);
					}
					this.SendPropertyChanged("Genre");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_MovieGenre", Storage="_Movie", ThisKey="movieID", OtherKey="Id", IsForeignKey=true)]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.MovieGenres.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.MovieGenres.Add(this);
						this._movieID = value.Id;
					}
					else
					{
						this._movieID = default(int);
					}
					this.SendPropertyChanged("Movie");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MoviePerson")]
	public partial class MoviePerson : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _movieID;
		
		private int _personID;
		
		private int _roleID;
		
		private EntityRef<Movie> _Movie;
		
		private EntityRef<Role> _Role;
		
		private EntityRef<Person> _Person;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnmovieIDChanging(int value);
    partial void OnmovieIDChanged();
    partial void OnpersonIDChanging(int value);
    partial void OnpersonIDChanged();
    partial void OnroleIDChanging(int value);
    partial void OnroleIDChanged();
    #endregion
		
		public MoviePerson()
		{
			this._Movie = default(EntityRef<Movie>);
			this._Role = default(EntityRef<Role>);
			this._Person = default(EntityRef<Person>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_movieID", DbType="Int NOT NULL")]
		public int movieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((this._movieID != value))
				{
					if (this._Movie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("movieID");
					this.OnmovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personID", DbType="Int NOT NULL")]
		public int personID
		{
			get
			{
				return this._personID;
			}
			set
			{
				if ((this._personID != value))
				{
					if (this._Person.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnpersonIDChanging(value);
					this.SendPropertyChanging();
					this._personID = value;
					this.SendPropertyChanged("personID");
					this.OnpersonIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roleID", DbType="Int NOT NULL")]
		public int roleID
		{
			get
			{
				return this._roleID;
			}
			set
			{
				if ((this._roleID != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnroleIDChanging(value);
					this.SendPropertyChanging();
					this._roleID = value;
					this.SendPropertyChanged("roleID");
					this.OnroleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_MoviePerson", Storage="_Movie", ThisKey="movieID", OtherKey="Id", IsForeignKey=true)]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.MoviePersons.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.MoviePersons.Add(this);
						this._movieID = value.Id;
					}
					else
					{
						this._movieID = default(int);
					}
					this.SendPropertyChanged("Movie");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_MoviePerson", Storage="_Role", ThisKey="roleID", OtherKey="Id", IsForeignKey=true)]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.MoviePersons.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.MoviePersons.Add(this);
						this._roleID = value.Id;
					}
					else
					{
						this._roleID = default(int);
					}
					this.SendPropertyChanged("Role");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Person_MoviePerson", Storage="_Person", ThisKey="personID", OtherKey="Id", IsForeignKey=true)]
		public Person Person
		{
			get
			{
				return this._Person.Entity;
			}
			set
			{
				Person previousValue = this._Person.Entity;
				if (((previousValue != value) 
							|| (this._Person.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Person.Entity = null;
						previousValue.MoviePersons.Remove(this);
					}
					this._Person.Entity = value;
					if ((value != null))
					{
						value.MoviePersons.Add(this);
						this._personID = value.Id;
					}
					else
					{
						this._personID = default(int);
					}
					this.SendPropertyChanged("Person");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Person")]
	public partial class Person : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _name;
		
		private string _gender;
		
		private int _birthyear;
		
		private string _nationality;
		
		private EntitySet<MoviePerson> _MoviePersons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnbirthyearChanging(int value);
    partial void OnbirthyearChanged();
    partial void OnnationalityChanging(string value);
    partial void OnnationalityChanged();
    #endregion
		
		public Person()
		{
			this._MoviePersons = new EntitySet<MoviePerson>(new Action<MoviePerson>(this.attach_MoviePersons), new Action<MoviePerson>(this.detach_MoviePersons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthyear", DbType="Int NOT NULL")]
		public int birthyear
		{
			get
			{
				return this._birthyear;
			}
			set
			{
				if ((this._birthyear != value))
				{
					this.OnbirthyearChanging(value);
					this.SendPropertyChanging();
					this._birthyear = value;
					this.SendPropertyChanged("birthyear");
					this.OnbirthyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nationality", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nationality
		{
			get
			{
				return this._nationality;
			}
			set
			{
				if ((this._nationality != value))
				{
					this.OnnationalityChanging(value);
					this.SendPropertyChanging();
					this._nationality = value;
					this.SendPropertyChanged("nationality");
					this.OnnationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Person_MoviePerson", Storage="_MoviePersons", ThisKey="Id", OtherKey="personID")]
		public EntitySet<MoviePerson> MoviePersons
		{
			get
			{
				return this._MoviePersons;
			}
			set
			{
				this._MoviePersons.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_MoviePersons(MoviePerson entity)
		{
			this.SendPropertyChanging();
			entity.Person = this;
		}
		
		private void detach_MoviePersons(MoviePerson entity)
		{
			this.SendPropertyChanging();
			entity.Person = null;
		}
	}
}
#pragma warning restore 1591
