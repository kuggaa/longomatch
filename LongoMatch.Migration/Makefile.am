ASSEMBLY = LongoMatch
TARGET = exe
INSTALL_DIR = $(pkglibdir)/migration
BUILD_DIR = bin/migration

LINK = $(REF_DEP_LONGOMATCH_MIGRATION)

SOURCES = ../AssemblyInfo/AssemblyInfo.cs \
	Common/Color.cs \
	Common/Config.cs \
	Common/ConsoleCrayon.cs \
	Common/Constants.cs \
	Common/Enums.cs \
	Common/Image.cs \
	Common/Log.cs \
	Common/SerializableObject.cs \
	Converter.cs \
	Core/Category.cs \
	Core/Coordinates.cs \
	Core/Drawing.cs \
	Core/GameUnit.cs \
	Core/GameUnitsList.cs \
	Core/HotKey.cs \
	Core/Interfaces/ISubCategory.cs \
	Core/Interfaces/ITag.cs \
	Core/Interfaces/ITemplates.cs \
	Core/Interfaces/ITimelineNode.cs \
	Core/MediaFile.cs \
	Core/Period.cs \
	Core/PixbufTimeNode.cs \
	Core/Play.cs \
	Core/PlayListPlay.cs \
	Core/Player.cs \
	Core/Point.cs \
	Core/Project.cs \
	Core/ProjectDescription.cs \
	Core/SubCategory.cs \
	Core/Tag.cs \
	Core/TagStore.cs \
	Core/Templates/CategoriesTemplate.cs \
	Core/Templates/SubCategoryTemplate.cs \
	Core/Templates/TeamTemplate.cs \
	Core/Time.cs \
	Core/TimeNode.cs \
	Core/TimelineNode.cs \
	Core/Timer.cs \
	DataBase.cs \
	MainWindow.cs \
	Program.cs \
	gtk-gui/MainWindow.cs \
	gtk-gui/generated.cs

RESOURCES = gtk-gui/gui.stetic \
	Data/default.lct \
	Data/default.ltt \
	Data/project.lgm \
	$(top_srcdir)/data/images/fields/field-half.svg \
	$(top_srcdir)/data/images/fields/field-goal.svg \
	$(top_srcdir)/data/images/fields/field-full.svg

include $(top_srcdir)/build/build.mk
