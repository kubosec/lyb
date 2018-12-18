package pdsu.hrms.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class JDBCTest {
	public void testQuery() {
		Connection conn = null;
		//1.��ȡ���ݿ�����
		try {
		Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
		conn = DriverManager.getConnection("jdbc:ucanaccess://HrMS.accdb");
		}catch(Exception e) {
			e.printStackTrace();
		}
		
		//ִ��SQL���
		String sql = "select * from dept order by deptId";
		PreparedStatement ps = null;
		ResultSet rs = null;
		try {
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		//�����ѯ���
		try {
			while(rs.next()) {
					String deptId = rs.getString(1);//��ʾ���ű��
					String dept1Name = rs.getString("dept1Name");
					System.out.println(deptId+" "+dept1Name);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		try {
			if(rs!=null)rs.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		try {
			if(ps!=null)ps.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		try {
			if(conn!=null)conn.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public static void main(String[] args) {
		JDBCTest test = new JDBCTest();
		test.testQuery();
	}
}
