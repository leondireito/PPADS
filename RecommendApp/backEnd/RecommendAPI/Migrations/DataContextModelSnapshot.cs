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

            modelBuilder.Entity("RecommendAPI.Entities.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AvaliadoPorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvaliadoPorUsername")
                        .HasColumnType("TEXT");

                    b.Property<string>("Comentario")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAvaliacao")
                        .HasColumnType("TEXT");

                    b.Property<int>("MidiaAvaliadaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AvaliadoPorId");

                    b.HasIndex("MidiaAvaliadaId");

                    b.ToTable("Avaliacoes");
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

            modelBuilder.Entity("RecommendAPI.Entities.Integrante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MidiaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MidiaId");

                    b.ToTable("Integrante");
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

                    b.Property<bool>("Avaliado")
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

            modelBuilder.Entity("RecommendAPI.Entities.MidiaLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LikeData")
                        .HasColumnType("TEXT");

                    b.Property<int>("MidiaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MidiaId");

                    b.HasIndex("UserId");

                    b.ToTable("Midialikes");
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

            modelBuilder.Entity("RecommendAPI.Entities.Relacionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataProposta")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserConvidaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserConvidadoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserConvidaId");

                    b.HasIndex("UserConvidadoId");

                    b.ToTable("Relacionamentos");
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

                    b.Property<int?>("ElencoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IntegranteId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Filme_IntegranteId");

                    b.HasIndex("ElencoId");

                    b.HasIndex("IntegranteId");

                    b.HasDiscriminator().HasValue("Filme");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Livro", b =>
                {
                    b.HasBaseType("RecommendAPI.Entities.Midia");

                    b.Property<int?>("AutorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EditoraId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IntegranteId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AutorId");

                    b.HasIndex("EditoraId");

                    b.HasIndex("IntegranteId");

                    b.HasDiscriminator().HasValue("Livro");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Serie", b =>
                {
                    b.HasBaseType("RecommendAPI.Entities.Midia");

                    b.Property<string>("Diretor")
                        .HasColumnType("TEXT")
                        .HasColumnName("Serie_Diretor");

                    b.Property<int?>("ElencoId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Serie_ElencoId");

                    b.Property<int?>("IntegranteId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("Serie_IntegranteId");

                    b.Property<int>("Temporadas")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ElencoId");

                    b.HasIndex("IntegranteId");

                    b.HasDiscriminator().HasValue("Serie");
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

            modelBuilder.Entity("RecommendAPI.Entities.Avaliacao", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", "AvaliadoPor")
                        .WithMany()
                        .HasForeignKey("AvaliadoPorId");

                    b.HasOne("RecommendAPI.Entities.Midia", "MidiaAvaliada")
                        .WithMany()
                        .HasForeignKey("MidiaAvaliadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AvaliadoPor");

                    b.Navigation("MidiaAvaliada");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Connection", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Group", null)
                        .WithMany("Connections")
                        .HasForeignKey("GroupName")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RecommendAPI.Entities.Integrante", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Midia", null)
                        .WithMany("Integrantes")
                        .HasForeignKey("MidiaId");
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

            modelBuilder.Entity("RecommendAPI.Entities.MidiaLike", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Midia", "Midida")
                        .WithMany()
                        .HasForeignKey("MidiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Midida");

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

            modelBuilder.Entity("RecommendAPI.Entities.Relacionamento", b =>
                {
                    b.HasOne("RecommendAPI.Entities.AppUser", "UserConvida")
                        .WithMany()
                        .HasForeignKey("UserConvidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecommendAPI.Entities.AppUser", "UserConvidado")
                        .WithMany()
                        .HasForeignKey("UserConvidadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserConvida");

                    b.Navigation("UserConvidado");
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

            modelBuilder.Entity("RecommendAPI.Entities.Filme", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Elenco", null)
                        .WithMany("Filmes")
                        .HasForeignKey("ElencoId");

                    b.HasOne("RecommendAPI.Entities.Integrante", null)
                        .WithMany("Filmes")
                        .HasForeignKey("IntegranteId");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Livro", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Autor", null)
                        .WithMany("Livros")
                        .HasForeignKey("AutorId");

                    b.HasOne("RecommendAPI.Entities.Editora", "Editora")
                        .WithMany()
                        .HasForeignKey("EditoraId");

                    b.HasOne("RecommendAPI.Entities.Integrante", null)
                        .WithMany("Livros")
                        .HasForeignKey("IntegranteId");

                    b.Navigation("Editora");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Serie", b =>
                {
                    b.HasOne("RecommendAPI.Entities.Elenco", null)
                        .WithMany("Series")
                        .HasForeignKey("ElencoId");

                    b.HasOne("RecommendAPI.Entities.Integrante", null)
                        .WithMany("Series")
                        .HasForeignKey("IntegranteId");
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

            modelBuilder.Entity("RecommendAPI.Entities.Autor", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Elenco", b =>
                {
                    b.Navigation("Filmes");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Group", b =>
                {
                    b.Navigation("Connections");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Integrante", b =>
                {
                    b.Navigation("Filmes");

                    b.Navigation("Livros");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("RecommendAPI.Entities.Midia", b =>
                {
                    b.Navigation("Integrantes");
                });
#pragma warning restore 612, 618
        }
    }
}
