// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroConDetalle.DAL;

namespace RegistroConDetalle.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("RegistroConDetalle.Entidades.Permisos", b =>
                {
                    b.Property<int>("PermisoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("PermisoID");

                    b.ToTable("Permisos");

                    b.HasData(
                        new
                        {
                            PermisoID = 1,
                            Descripcion = "Area Ciberseguridad",
                            Nombre = "Pedro Solorin"
                        },
                        new
                        {
                            PermisoID = 2,
                            Descripcion = "Administrador",
                            Nombre = "Randis Tejada"
                        });
                });

            modelBuilder.Entity("RegistroConDetalle.Entidades.Roles", b =>
                {
                    b.Property<int>("RoiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoiID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("RegistroConDetalle.Entidades.RolesDetalle", b =>
                {
                    b.Property<int>("RolesDetalleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EsAsignado")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermisoID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoiID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolesDetalleID");

                    b.HasIndex("PermisoID");

                    b.HasIndex("RoiID");

                    b.ToTable("RolesDetalle");
                });

            modelBuilder.Entity("RegistroConDetalle.Entidades.RolesDetalle", b =>
                {
                    b.HasOne("RegistroConDetalle.Entidades.Permisos", null)
                        .WithMany("RolesDetalle")
                        .HasForeignKey("PermisoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroConDetalle.Entidades.Roles", null)
                        .WithMany("RolesDetalle")
                        .HasForeignKey("RoiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistroConDetalle.Entidades.Permisos", b =>
                {
                    b.Navigation("RolesDetalle");
                });

            modelBuilder.Entity("RegistroConDetalle.Entidades.Roles", b =>
                {
                    b.Navigation("RolesDetalle");
                });
#pragma warning restore 612, 618
        }
    }
}
