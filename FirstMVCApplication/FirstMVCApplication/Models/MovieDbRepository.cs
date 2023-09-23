using FirstMVCApp.Models;
using FirstMVCApplication.Models;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FirstMVCApplication.Models
{
    public class MovieDbRepository
    {
        public static List<Movie> GetMviList()
        {
            List<Movie> Mvilist = new List<Movie>();
            using (SqlConnection cn = SQLHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectMvicmd = cn.CreateCommand();
                String selectAllMvi = "Select * from MovieTable";
                selectMvicmd.CommandText = selectAllMvi;
                SqlDataReader Mvidr = selectMvicmd.ExecuteReader();
                while (Mvidr.Read())
                {
                    Movie mvi = new Movie
                    {
                        SNo = Mvidr.GetInt32(0),
                        Title = Mvidr.GetString(1),
                        Language = Mvidr.GetString(2),
                        HeroName = Mvidr.GetString(3),
                        DirectorName= Mvidr.GetString(4),
                        MDirector=Mvidr.GetString(5),
                        ReleaseDate = Mvidr.GetDateTime(6),
                        Cost =Mvidr.GetDecimal(1),
                        Collection = Mvidr.GetDecimal(2),
                        Review=Mvidr.GetString(6)
                    };
                    Mvilist.Add(mvi);

                }
            }
                return Mvilist;
        }
        public static Movie GetMviByName(int SNo)
        {
            Movie MviFound = null;
            using (SqlConnection cn = SQLHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmvicmd = cn.CreateCommand();
                String selectMvis = "Select * from MovieTable where SNo=@No";
                selectmvicmd.Parameters.Add("@SNo", SqlDbType.Int).Value = SNo;
                selectmvicmd.CommandText = selectMvis;
                SqlDataReader Mvidr = selectmvicmd.ExecuteReader();
                while (Mvidr.Read())
                {
                    MviFound = new Movie
                    {
                        SNo = Mvidr.GetInt32(0),
                        Title = Mvidr.GetString(1),
                        Language = Mvidr.GetString(2),
                        HeroName = Mvidr.GetString(3),
                        DirectorName = Mvidr.GetString(4),
                        MDirector = Mvidr.GetString(5),
                        ReleaseDate = Mvidr.GetDateTime(6),
                        Cost = Mvidr.GetDecimal(1),
                        Collection = Mvidr.GetDecimal(2),
                        Review = Mvidr.GetString(6)
                    };
                }
            }
            return MviFound;
        }
        
        public static int AddNewMvi(Movie newMvi)
        {
            int query_result = 0;
            using (SqlConnection cn = SQLHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertMvicmd = cn.CreateCommand();
                String insertNewMovieQuery = "insert into MovieTable values( @SNo,@Title, @Language,@HeroName, " +
                    "@DirectorName, @MDirector, @ReleaseDate, @Cost, @Collection, @Review)";
                insertMvicmd.Parameters.Add("@SNo", SqlDbType.Int).Value = newMvi.SNo;
                insertMvicmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = newMvi.Title;
                insertMvicmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = newMvi.Language;
                insertMvicmd.Parameters.Add("@HeroName", SqlDbType.NVarChar).Value = newMvi.HeroName;
                insertMvicmd.Parameters.Add("@DirectorName", SqlDbType.NVarChar).Value = newMvi.DirectorName;
                insertMvicmd.Parameters.Add("@MDirector", SqlDbType.NVarChar).Value = newMvi.MDirector;
                insertMvicmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value= newMvi.ReleaseDate;
                insertMvicmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = newMvi.Review;
                insertMvicmd.Parameters.Add("@Collections", SqlDbType.Decimal).Value = newMvi.Collection;
                insertMvicmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = newMvi.Cost;
                
                insertMvicmd.CommandText = insertNewMovieQuery;
                query_result = insertMvicmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int UpdateMvi(Movie ModifiedMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SQLHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateMvicmd = cn.CreateCommand();
                String updateMovieQuery = "insert into MovieTable values( @SNo,@Title, @Language,@HeroName, " +
                    "@DirectorName, @MDirector, @ReleaseDate, @Cost, @Collection, @Review)";
                updateMvicmd.Parameters.Add("@SNo", SqlDbType.Int).Value = ModifiedMovie.SNo;
                updateMvicmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = ModifiedMovie.Title;
                updateMvicmd.Parameters.Add("@Language", SqlDbType.NVarChar).Value = ModifiedMovie.Language;
                updateMvicmd.Parameters.Add("@HeroName", SqlDbType.NVarChar).Value = ModifiedMovie.HeroName;
                updateMvicmd.Parameters.Add("@DirectorName", SqlDbType.NVarChar).Value = ModifiedMovie.DirectorName;
                updateMvicmd.Parameters.Add("@MDirector", SqlDbType.NVarChar).Value = ModifiedMovie.MDirector;
                updateMvicmd.Parameters.Add("@Cost", SqlDbType.Decimal).Value = ModifiedMovie.Cost;
                updateMvicmd.Parameters.Add("@Review", SqlDbType.NVarChar).Value = ModifiedMovie.Review;
                updateMvicmd.Parameters.Add("@Collection", SqlDbType.Decimal).Value = ModifiedMovie.Collection;
                updateMvicmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = ModifiedMovie.ReleaseDate;
                updateMvicmd.CommandText = updateMovieQuery;
                query_result = updateMvicmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeleteMvi(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SQLHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteMvicmd = cn.CreateCommand();
                String deleteMovieQuery = "Delete from MoivieTablewhere SNo=@sno";
                deleteMvicmd.Parameters.Add("@SNo", SqlDbType.Int).Value = id;
                deleteMvicmd.CommandText = deleteMovieQuery;
                query_result = deleteMvicmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}