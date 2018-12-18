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
	
//	//查询所有员工的基本信息
//		public static String[][] getAllForBasic(){
//			return ;
//		}
//		
		//查询员工的部门信息
		public static String[] getDeptsinfoForSelect(Dept dept) {
			//获取数据库连接
			Connection conn = DBUtil.getConnection();
			PreparedStatement ps = null;
			ResultSet rs = null;
			//存储数据用的集合类
			List<Dept> list = new LinkedList<Dept>();
			String[] data = null;
			try {
				//查询
				String sql = "select * from dept where deptId=(?)";
				ps = conn.prepareStatement(sql);
				ps.setLong(1, dept.getDeptId());
				rs = ps.executeQuery();
				//处理结果集
				while(rs.next()) {
					Dept dept1 = new Dept();
					dept1.setDeptId(rs.getLong("deptId"));
					dept1.setDept1Name(rs.getString("dept1Name"));
					dept1.setDept2Name(rs.getString("dept2Name"));
					list.add(dept1);
				}
				//把list转换为二维数组
				data = new String[list.size()];
				for(int i=0;i<list.size();i++) {
					data[i] = String.valueOf(list.get(i).getDept1Name())+'-'+list.get(i).getDept2Name();
				}
			}catch(Exception e) {
				JOptionPane.showMessageDialog(null, e.getMessage());
			}finally {
				//关闭数据库连接
				DBUtil.close(rs);DBUtil.close(ps);DBUtil.close(conn);
			}
			return data;
		}
		
		//修改特定编号的部门数据
		public static void update(Dept dept) {
//			//准备测试数据
//			Dept dept = new Dept(14,"测试一","测试二");
			//获取数据库连接
			Connection conn = DBUtil.getConnection();
			//更新
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
				//关闭数据库连接
				DBUtil.close(ps);
				DBUtil.close(conn);
			}
		}
		
		//根据部门编号删除某部门数据
		public static void delete(long deptId) {
			Connection conn = DBUtil.getConnection();
			//更新
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
				//关闭数据库连接
				DBUtil.close(ps);
				DBUtil.close(conn);
			}
		}
//		
		//获取下一个可用的部门编号
		public static long getNextId() {
			Dept dept = new Dept();
			//获取数据库连接
			Connection conn = DBUtil.getConnection();
			//更新
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
				//关闭数据库连接
				DBUtil.close(rs);
				DBUtil.close(ps);
				DBUtil.close(conn);
			}
			return (dept.getDeptId()+1);
		}
//		
//		//获取字符串形式的部门信息列表
		public static String[] getDeptsForSelect() {
			
			//获取数据库连接
			Connection conn = DBUtil.getConnection();
			PreparedStatement ps = null;
			ResultSet rs = null;
			//存储数据用的集合类
			List<Dept> list = new LinkedList<Dept>();
			String[] data = null;
			try {
				//查询
				String sql = "select * from dept";
				ps = conn.prepareStatement(sql);
				rs = ps.executeQuery();
				//处理结果集
				while(rs.next()) {
					Dept dept = new Dept();
					dept.setDeptId(rs.getLong("deptId"));
					dept.setDept1Name(rs.getString("dept1Name"));
					dept.setDept2Name(rs.getString("dept2Name"));
					list.add(dept);
				}
				//把list转换为二维数组
				data = new String[list.size()];
				for(int i=0;i<list.size();i++) {
					data[i] = String.valueOf(list.get(i).getDeptId())+'-'+list.get(i).getDept1Name()+'-'+list.get(i).getDept2Name();
				}
			}catch(Exception e) {
				JOptionPane.showMessageDialog(null, e.getMessage());
			}finally {
				//关闭数据库连接
				DBUtil.close(rs);DBUtil.close(ps);DBUtil.close(conn);
			}
			return data;
		}
//	
	
	//以二维数据形式返回所有部门数据
	public static String[][] getDeptsForTable(){
		//获取数据库连接
		Connection conn = DBUtil.getConnection();
		PreparedStatement ps = null;
		ResultSet rs = null;
		//存储数据用的集合类
		List<Dept> list = new LinkedList<Dept>();
		String[][] data = null;
		try {
			//查询
			String sql = "select * from dept";
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			//处理结果集
			while(rs.next()) {
				Dept dept = new Dept();
				dept.setDeptId(rs.getLong("deptId"));
				dept.setDept1Name(rs.getString("dept1Name"));
				dept.setDept2Name(rs.getString("dept2Name"));
				
				list.add(dept);
			}
			//把list转换为二维数组
			data = new String[list.size()][3];
			for(int i=0;i<list.size();i++) {
				data[i][0] = String.valueOf(list.get(i).getDeptId());
				data[i][1] = list.get(i).getDept1Name();
				data[i][2] = list.get(i).getDept2Name();
			}
		}catch(Exception e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		}finally {
			//关闭数据库连接
			DBUtil.close(rs);DBUtil.close(ps);DBUtil.close(conn);
		}
		return data;
	}
	public static void add(Dept dept) {
		//准备测试数据
//		Dept dept = new Dept();
		//获取数据库连接
		Connection conn = DBUtil.getConnection();
		//更新
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
			//关闭数据库连接
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
	}
	

}
