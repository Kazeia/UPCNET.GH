/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.upc.upcnet.dao;

import com.upc.upcnet.entidades.Alumno;
import java.util.ArrayList;
import java.util.List;
import com.upc.upcnet.BD.AccesoDB;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

/**
 *
 * @author win7
 */
public class AlumnoDAO {
    
    public List<Alumno> getAlumnos(){
        List<Alumno> alumnos = new ArrayList<>();
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            StringBuilder query = new StringBuilder();
            query.append("SELECT IDAlumno, Nombre, Apellido, DNI, Edad, Correo, Direccion, IDCategoria, IDApoderado FROM Alumno");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                Alumno a = new Alumno();
                a.setIdAlumno(rs.getString("IDAlumno"));
                a.setNombre(rs.getString("Nombre"));
                a.setApellido(rs.getString("Apellido"));
                a.setDni(rs.getInt("DNI"));
                a.setEdad(rs.getInt("Edad"));
                a.setCorreo(rs.getString("Correo"));
                a.setDireccion(rs.getString("Direccion"));
                a.setIdCategoria(rs.getString("IDCategoria"));
                a.setIdApoderado(rs.getString("IDApoderado"));
                
                alumnos.add(a);
            }
        }catch(SQLException ex){
            throw new RuntimeException(ex.getMessage());
        }catch(Exception e){
            throw new RuntimeException("No se tiene acceso al servidor");
        }finally{
            try{
                if(cn != null)
                    cn.close();
            }catch(Exception ex){}
        }
        return alumnos;
    }
    
    public void setAlumno(String _idAlumno, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _idCategoria, String _idApoderado){
        Connection cn = null;        
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("SELECT * FROM Alumno WHERE IDAlumno = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idAlumno);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
                throw new SQLException("El codigo del alumno ya existe");
            
            query = new StringBuilder();
            query.append("INSERT INTO Alumno(IDAlumno, Nombre, Apellido, DNI, Edad, Correo, Direccion, IDCategoria, IDApoderado) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?)");
            ps = cn.prepareStatement(query.toString());
            ps.setString(1, _idAlumno);
            ps.setString(1, _nombre);
            ps.setString(1, _apellido);
            ps.setString(1, _dni);
            ps.setString(1, _edad);
            ps.setString(1, _correo);
            ps.setString(1, _direccion);
            ps.setString(1, _idCategoria);
            ps.setString(1, _idApoderado);
            ps.executeUpdate();
            cn.commit();
            
        }catch(SQLException ex){
            throw new RuntimeException(ex.getMessage());
        }catch(Exception e){
            throw new RuntimeException("No se tiene acceso al servidor");
        }finally{
            try{
                if(cn != null)
                    cn.close();
            }catch(Exception ex){}
        }
    }
    
    public void editAlumno(String _idAlumno, String _nombre, String _apellido, String _dni, String _edad, String _correo, String _direccion, String _idCategoria, String _idApoderado){
        Connection cn = null;
        try{
            cn = AccesoDB.getConnection();
            cn.setAutoCommit(false);
            StringBuilder query = new StringBuilder();
            query.append("UPDATE Alumno SET Nombre = ?, Apellido = ?, DNI = ?, Edad = ?, Correo = ?, Direccion = ?, IDCategoria = ?, IDApoderado = ? WHERE IDAlumno = ?");
            PreparedStatement ps = cn.prepareStatement(query.toString());
            ps.setString(1, _nombre);
            ps.setString(2, _apellido);
            ps.setString(3, _dni);
            ps.setString(4, _edad);
            ps.setString(5, _correo);
            ps.setString(6, _direccion);
            ps.setString(7, _idCategoria);
            ps.setString(8, _idApoderado);
            ps.setString(9, _idAlumno);
            int realizado = ps.executeUpdate();
            if(realizado == 0)
                throw  new SQLException("Alumno no existe!");            
        }catch(SQLException ex){
            throw new RuntimeException(ex.getMessage());
        }catch(Exception e){
            throw new RuntimeException("No se tiene acceso al servidor");
        }finally{
            try{
                if(cn != null)
                    cn.close();
            }catch(Exception ex){}
        }
        
    }
}
