﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecommendAPI.Data;

namespace RecommendAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("AutorLivro", b =>
                {
                    b.Property<int>("AutoresId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LivrosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AutoresId", "LivrosId");

                    b.HasIndex("LivrosId");

                    b.ToTable("AutorLivro");
                });

            modelBuilder.Entity("ElencoFilme", b =>
                {
                    b.Property<int>("ElencosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FilmesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ElencosId", "FilmesId");

                    b.HasIndex("FilmesId");

                    b.ToTable("ElencoFilme");
                });

            modelBuilder.Entity("ElencoSerie", b =>
                {
                    b.Property<int>("ElencosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeriesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ElencosId", "SeriesId");

                    b.HasIndex("SeriesId");

                    b.ToTable("ElencoSerie");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<int>("PostsPostId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsTagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PostsPostId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("RecommendAPI.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("RecommendAPI.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interests")
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasColumnType("TEXT");

                    b.Property<string>("KnownAs")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("LookingFor")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RecommendAPI.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Connection", b =>
                {
                    b.Property<string>("ConnectionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("ConnectionId");

                    b.HasIndex("GroupName");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Editora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Editoras");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Elenco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Elenco");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Group", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("TEXT");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RecipientUsername")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SenderUsername")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Midia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ano")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Criado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FotoUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Lancamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Midias");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Midia");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("RecommendAPI.Entities.UserLike", b =>
                {
                    b.Property<int>("SourceUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LikedUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SourceUserId", "LikedUserId");

                    b.HasIndex("LikedUserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Filme", b =>
                {
                    b.HasBaseType("RecommendAPI.Entities.Midia");

                    b.Property<string>("Diretor")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Filme");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Livro", b =>
                {
                    b.HasBaseType("RecommendAPI.Entities.Midia");

                    b.Property<int?>("EditoraId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("EditoraId");

                    b.HasDiscriminator().HasValue("Livro");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Serie", b =>
                {
                    b.HasBaseType("RecommendAPI.Entities.Midia");

                    b.Property<string>("Diretor")
                        .HasColumnType("TEXT")
                        .HasColumnName("Serie_Diretor");

                    b.Property<int>("Temporadas")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Serie");
                });

            modelBuilder.Entity("AutorLivro", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Autor", null)
                        .WithMany()
                        .HasForeignKey("AutoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.Livro", null)
                        .WithMany()
                        .HasForeignKey("LivrosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ElencoFilme", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Elenco", null)
                        .WithMany()
                        .HasForeignKey("ElencosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.Filme", null)
                        .WithMany()
                        .HasForeignKey("FilmesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ElencoSerie", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Elenco", null)
                        .WithMany()
                        .HasForeignKey("ElencosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.Serie", null)
                        .WithMany()
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Post", null)
                        .WithMany()
                        .HasForeignKey("PostsPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecommendAPI.Entities.AppUserRole", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Connection", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Group", null)
                        .WithMany("Connections")
                        .HasForeignKey("GroupName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RecommendAPI.Entities.Message", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", "Recipient")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.AppUser", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Midia", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Photo", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", "AppUser")
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("RecommendAPI.Entities.UserLike", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", "LikedUser")
                        .WithMany("LikedByUsers")
                        .HasForeignKey("LikedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.AppUser", "SourceUser")
                        .WithMany("LikedUsers")
                        .HasForeignKey("SourceUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LikedUser");

                    b.Navigation("SourceUser");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Livro", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Editora", "Editora")
                        .WithMany()
                        .HasForeignKey("EditoraId");

                    b.Navigation("Editora");
                });

            modelBuilder.Entity("RecommendAPI.Entities.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("RecommendAPI.Entities.AppUser", b =>
                {
                    b.Navigation("LikedByUsers");

                    b.Navigation("LikedUsers");

                    b.Navigation("MessagesReceived");

                    b.Navigation("MessagesSent");

                    b.Navigation("Photos");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Group", b =>
                {
                    b.Navigation("Connections");
                });
#pragma warning restore 612, 618
        }
    }
}