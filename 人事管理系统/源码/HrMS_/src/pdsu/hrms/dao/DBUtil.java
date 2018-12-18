package pdsu.hrms.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class DBUtil {
	public static Connection getConnection() {
		Connection conn = null;
		//1.获取数据库连接
		try {
		Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
		conn = DriverManager.getConnection("jdbc:ucanaccess://HrMS.accdb");
		}catch(Exception e) {
			e.printStackTrace();
		}
		return conn;
	}
	//关闭结果集
	public static void close(ResultSet rs) {
		try {
			if(rs!=null)rs.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	//关闭语句
	public static void close(PreparedStatement ps) {
		try {
			if(ps!=null)ps.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	//关闭连接
	public static void close(Connection conn) {
		try {
			if(conn!=null)conn.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
