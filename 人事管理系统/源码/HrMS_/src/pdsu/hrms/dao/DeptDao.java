package pdsu.hrms.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.LinkedList;
import java.util.List;

import javax.swing.JOptionPane;

import pdsu.hrms.model.Dept;

public class DeptDao {
	
//	//��ѯ����Ա���Ļ�����Ϣ
//		public static String[][] getAllForBasic(){
//			return ;
//		}
//		
		//��ѯԱ���Ĳ�����Ϣ
		public static String[] getDeptsinfoForSelect(Dept dept) {
			//��ȡ���ݿ�����
			Connection conn = DBUtil.getConnection();
			PreparedStatement ps = null;
			ResultSet rs = null;
			//�洢�����õļ�����
			List<Dept> list = new LinkedList<Dept>();
			String[] data = null;
			try {
				//��ѯ
				String sql = "select * from dept where deptId=(?)";
				ps = conn.prepareStatement(sql);
				ps.setLong(1, dept.getDeptId());
				rs = ps.executeQuery();
				//��������
				while(rs.next()) {
					Dept dept1 = new Dept();
					dept1.setDeptId(rs.getLong("deptId"));
					dept1.setDept1Name(rs.getString("dept1Name"));
					dept1.setDept2Name(rs.getString("dept2Name"));
					list.add(dept1);
				}
				//��listת��Ϊ��ά����
				data = new String[list.size()];
				for(int i=0;i<list.size();i++) {
					data[i] = String.valueOf(list.get(i).getDept1Name())+'-'+list.get(i).getDept2Name();
				}
			}catch(Exception e) {
				JOptionPane.showMessageDialog(null, e.getMessage());
			}finally {
				//�ر����ݿ�����
				DBUtil.close(rs);DBUtil.close(ps);DBUtil.close(conn);
			}
			return data;
		}
		
		//�޸��ض���ŵĲ�������
		public static void update(Dept dept) {
//			//׼����������
//			Dept dept = new Dept(14,"����һ","���Զ�");
			//��ȡ���ݿ�����
			Connection conn = DBUtil.getConnection();
			//����
			PreparedStatement ps = null;
			String sql = "update dept set "
					+ "dept1Name=(?),dept2Name=(?) where deptId=(?)";
			try {
//				System.out.println(sql);
				ps = conn.prepareStatement(sql);
				ps.setLong(3, dept.getDeptId());
				ps.setString(1, dept.getDept1Name());
				ps.setString(2, dept.getDept2Name());
				ps.executeUpdate();
				conn.commit();
			}catch(SQLException e) {
				e.printStackTrace();
			}finally {
				//�ر����ݿ�����
				DBUtil.close(ps);
				DBUtil.close(conn);
			}
		}
		
		//���ݲ��ű��ɾ��ĳ��������
		public static void delete(long deptId) {
			Connection conn = DBUtil.getConnection();
			//����
			PreparedStatement ps = null;
			String sql = "delete * from Dept where deptId=(?)";
			try {
//				System.out.println(sql);
				ps = conn.prepareStatement(sql);
				ps.setLong(1, deptId);
				ps.executeUpdate();
//				conn.commit();
			}catch(SQLException e) {
				e.printStackTrace();
			}finally {
				//�ر����ݿ�����
				DBUtil.close(ps);
				DBUtil.close(conn);
			}
		}
//		
		//��ȡ��һ�����õĲ��ű��
		public static long getNextId() {
			Dept dept = new Dept();
			//��ȡ���ݿ�����
			Connection conn = DBUtil.getConnection();
			//����
			PreparedStatement ps = null;
			ResultSet rs = null;
			int id=0;
			String sql = "select max(deptId) from Dept";
			try {
				ps = conn.prepareStatement(sql);
				rs = ps.executeQuery();
				while(rs.next()) {
					
					dept.setDeptId(rs.getInt(1));
				}
			}catch(SQLException e) {
				e.printStackTrace();
			}finally {
				//�ر����ݿ�����
				DBUtil.close(rs);
				DBUtil.close(ps);
				DBUtil.close(conn);
			}
			return (dept.getDeptId()+1);
		}
//		
//		//��ȡ�ַ�����ʽ�Ĳ�����Ϣ�б�
		public static String[] getDeptsForSelect() {
			
			//��ȡ���ݿ�����
			Connection conn = DBUtil.getConnection();
			PreparedStatement ps = null;
			ResultSet rs = null;
			//�洢�����õļ�����
			List<Dept> list = new LinkedList<Dept>();
			String[] data = null;
			try {
				//��ѯ
				String sql = "select * from dept";
				ps = conn.prepareStatement(sql);
				rs = ps.executeQuery();
				//��������
				while(rs.next()) {
					Dept dept = new Dept();
					dept.setDeptId(rs.getLong("deptId"));
					dept.setDept1Name(rs.getString("dept1Name"));
					dept.setDept2Name(rs.getString("dept2Name"));
					list.add(dept);
				}
				//��listת��Ϊ��ά����
				data = new String[list.size()];
				for(int i=0;i<list.size();i++) {
					data[i] = String.valueOf(list.get(i).getDeptId())+'-'+list.get(i).getDept1Name()+'-'+list.get(i).getDept2Name();
				}
			}catch(Exception e) {
				JOptionPane.showMessageDialog(null, e.getMessage());
			}finally {
				//�ر����ݿ�����
				DBUtil.close(rs);DBUtil.close(ps);DBUtil.close(conn);
			}
			return data;
		}
//	
	
	//�Զ�ά������ʽ�������в�������
	public static String[][] getDeptsForTable(){
		//��ȡ���ݿ�����
		Connection conn = DBUtil.getConnection();
		PreparedStatement ps = null;
		ResultSet rs = null;
		//�洢�����õļ�����
		List<Dept> list = new LinkedList<Dept>();
		String[][] data = null;
		try {
			//��ѯ
			String sql = "select * from dept";
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			//��������
			while(rs.next()) {
				Dept dept = new Dept();
				dept.setDeptId(rs.getLong("deptId"));
				dept.setDept1Name(rs.getString("dept1Name"));
				dept.setDept2Name(rs.getString("dept2Name"));
				
				list.add(dept);
			}
			//��listת��Ϊ��ά����
			data = new String[list.size()][3];
			for(int i=0;i<list.size();i++) {
				data[i][0] = String.valueOf(list.get(i).getDeptId());
				data[i][1] = list.get(i).getDept1Name();
				data[i][2] = list.get(i).getDept2Name();
			}
		}catch(Exception e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		}finally {
			//�ر����ݿ�����
			DBUtil.close(rs);DBUtil.close(ps);DBUtil.close(conn);
		}
		return data;
	}
	public static void add(Dept dept) {
		//׼����������
//		Dept dept = new Dept();
		//��ȡ���ݿ�����
		Connection conn = DBUtil.getConnection();
		//����
		PreparedStatement ps = null;
		String sql = "insert into dept(deptId,dept1Name,dept2Name)"
				+ "values(?,?,?)";
		try {
			ps = conn.prepareStatement(sql);
			ps.setLong(1, dept.getDeptId());
			ps.setString(2, dept.getDept1Name());
			ps.setString(3, dept.getDept2Name());
			ps.executeUpdate();
			conn.commit();
		}catch(SQLException e) {
			e.printStackTrace();
		}finally {
			//�ر����ݿ�����
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
	}
	

}
