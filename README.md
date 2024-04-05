# OBJ to STL Converter

This repository contains C# code for converting OBJ files to STL format.

## Description

The repository includes the following files:

1. **ObjReader.cs**: This class is responsible for reading OBJ files and extracting the vertex and face data.

2. **OBJtoSTLConverter.cs**: This class converts OBJ files to STL format. It utilizes the `ObjReader`, `ObjWriter`, and `Triangulation` classes.

3. **ObjWriter.cs**: This class writes the extracted vertex data to a temporary file.

4. **Point3D.cs**: This class represents a 3D point with X, Y, and Z coordinates.

5. **Triangle.cs**: This class represents a triangle with three vertex indices.

6. **Triangulation.cs**: This class manages the triangulation process by storing triangles and unique 3D points.

## Usage

To use the converter:

1. Provide the path to the input OBJ file and the desired output STL file path to the `ObjToStlConvertor` method in `OBJtoSTLConverter.cs`.
2. Run the program.

## About OBJ and STL Files

### OBJ (.obj)

OBJ (or .OBJ) is a geometry definition file format first developed by Wavefront Technologies for its Advanced Visualizer animation package. It is one of the most common file formats used in 3D printing and computer graphics. OBJ files contain geometry definitions of objects, including vertices, normals and texture coordinates. 
### STL (.stl)

STL (STereoLithography) is a file format native to the stereolithography CAD software created by 3D Systems. It represents a 3D model as an approximation of the surfaces of a solid model by triangles. 

<hr>
<hr>

# STL to OBJ Converter

This repository contains C# code for converting STL files to OBJ format.

## Description

The repository includes the following files:

1. **STLReader.cs**: This class is responsible for reading STL files and extracting vertex and triangle data.

2. **Comparator.cs**: This class provides a comparison method for sorting points.

3. **Vertex.cs**: This class represents a vertex with X, Y, and Z coordinates.

4. **STLtoOBJConverter.cs**: This class converts STL files to OBJ format. It utilizes the `STLReader`, `STLWriter`, and `Triangulation` classes.

5. **STLWriter.cs**: This class writes the extracted vertex and triangle data to a temporary file.

6. **Triangle.cs**: This class represents a triangle with three vertex indices.

7. **Triangulation.cs**: This class manages the triangulation process by storing triangles and unique 3D points.

## Usage

To use the converter:

1. Provide the path to the input STL file and the desired output OBJ file path to the `StlToObjConverter` method in `STLtoOBJConverter.cs`.
2. Run the program.

## About STL and OBJ Files

### STL (.stl)

STL (STereoLithography) is a file format native to the stereolithography CAD software created by 3D Systems. It represents a 3D model as an approximation of the surfaces of a solid model by triangles. 
### OBJ (.obj)

OBJ (or .OBJ) is a geometry definition file format first developed by Wavefront Technologies for its Advanced Visualizer animation package. It is one of the most common file formats used in 3D printing and computer graphics. OBJ files contain geometry definitions of objects, including vertices, normals, texture coordinates, and other information about the 3D model's surface geometry.

These converters aim to facilitate interoperability between different 3D modeling software or 3D printing applications that utilize either of these file formats.
