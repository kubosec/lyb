package pdsu.hrms.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.LinkedList;
import java.util.List;

import javax.swing.JOptionPane;

import pdsu.hrms.model.Dept;
import pdsu.hrms.model.Person;

public class PersonDao {
	public static String[] getPersonsForTable1() {
		// 获取数据库连接
		Connection conn = DBUtil.getConnection();
		PreparedStatement ps = null;
		ResultSet rs = null;
		// 存储数据用的集合类
		List<Person> list = new LinkedList<Person>();
		String[] data = null;
		try {
			// 查询
			String sql = "select personId,pName from person";
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			// 处理结果集
			while (rs.next()) {
				Person person = new Person();
//				dept.setDeptId(rs.getLong("deptId"));
//				dept.setDept1Name(rs.getString("dept1Name"));
//				dept.setDept2Name();

//				System.out.println(rs.getLong("personId"));

				person.setPersonId(rs.getLong("personId"));
				person.setName(rs.getString("pName"));
//				person.setBirth(rs.getString("birth"));
//				person.setNat(rs.getString("nat"));
//				person.setAddress(rs.getString("address"));
//				person.setDept(Long.parseLong(deptId));

				// 获取部门信息
//				Dept dept = new Dept();
//				dept.setDeptId(rs.getLong("deptId"));
//				String[] persond = DeptDao.getDeptsinfoForSelect(dept);
//				System.out.println(persond[0]);
//				person.setPersond(persond[0]);
//				String[] depts = DeptDao.getDeptsForSelect();
//				for(int i=0;i<depts.length;i++) {
//					comboDept.addItem(depts[i]);
//				}

				list.add(person);
			}
			// 把list转换为数组
			data = new String[list.size()];
			for (int i = 0; i < list.size(); i++) {
				data[i] = String.valueOf(list.get(i).getPersonId()) + '-' + list.get(i).getName();
			}
			// +'-'+list.get(i).getName()
			// 把list转换为二维数组
//			data = new String[list.size()][6];
//			for (int i = 0; i < list.size(); i++) {
//				data[i][0] = String.valueOf(list.get(i).getPersonId());
//				data[i][1] = list.get(i).getName();
////				data[i][2] = list.get(i).getBirth();
////				data[i][3] = list.get(i).getNat();
////				data[i][4] = list.get(i).getAddress();
////				data[i][5] = list.get(i).getPersond();
////				
//			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		} finally {
			// 关闭数据库连接
			DBUtil.close(rs);
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
		return data;
	}

	public static String[][] getPersonsForTable() {
		// 获取数据库连接
		Connection conn = DBUtil.getConnection();
		PreparedStatement ps = null;
		ResultSet rs = null;
		// 存储数据用的集合类
		List<Person> list = new LinkedList<Person>();
		String[][] data = null;
		try {
			// 查询
			String sql = "select * from person";
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			// 处理结果集
			while (rs.next()) {
				Person person = new Person();
//				dept.setDeptId(rs.getLong("deptId"));
//				dept.setDept1Name(rs.getString("dept1Name"));
//				dept.setDept2Name();

				person.setPersonId(rs.getLong("personId"));
				person.setName(rs.getString("pName"));
				person.setBirth(rs.getString("birth"));
				person.setNat(rs.getString("nat"));
				person.setAddress(rs.getString("address"));
//				person.setDept(Long.parseLong(deptId));

				// 获取部门信息
				Dept dept = new Dept();
				dept.setDeptId(rs.getLong("deptId"));
				String[] persond = DeptDao.getDeptsinfoForSelect(dept);
//				System.out.println(persond[0]);
				person.setPersond(persond[0]);
//				String[] depts = DeptDao.getDeptsForSelect();
//				for(int i=0;i<depts.length;i++) {
//					comboDept.addItem(depts[i]);
//				}

				list.add(person);
			}
			// 把list转换为二维数组
//			data = new String[list.size()][6];
//			for(int i=0;i<list.size();i++) {
//				data[i][0] = String.valueOf(list.get(i).getPersonId()+'-'+list.get(i).getName());
//			}
			// 把list转换为二维数组
			data = new String[list.size()][6];
			for (int i = 0; i < list.size(); i++) {
				data[i][0] = String.valueOf(list.get(i).getPersonId());
				data[i][1] = list.get(i).getName();
				data[i][2] = list.get(i).getBirth();
				data[i][3] = list.get(i).getNat();
				data[i][4] = list.get(i).getAddress();
				data[i][5] = list.get(i).getPersond();
//				
			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		} finally {
			// 关闭数据库连接
			DBUtil.close(rs);
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
		return data;
	}

	public static String[][] getPersonsForSelect(Person person) {
		// 获取数据库连接
		Connection conn = DBUtil.getConnection();
		PreparedStatement ps = null;
		ResultSet rs = null;
		// 存储数据用的集合类
		List<Person> list = new LinkedList<Person>();
		String[][] data = null;
		try {
			// 查询
			String sql = "select * from person where personId=(?)";
			ps = conn.prepareStatement(sql);
//			System.out.println(person.getPersonId());
			ps.setLong(1, person.getPersonId());
			rs = ps.executeQuery();
			// 处理结果集
			while (rs.next()) {
				Person person_tmp = new Person();
//				dept.setDeptId(rs.getLong("deptId"));
//				dept.setDept1Name(rs.getString("dept1Name"));
//				dept.setDept2Name();
//				System.out.println(rs.getString("pName"));
//				System.out.println(rs.getString("sex"));
//				System.out.println(rs.getString("birth"));
//				System.out.println(rs.getString("nat"));
//				System.out.println(rs.getString("address"));
//				
//				System.out.println(rs.getString("other"));
//				System.out.println(rs.getString(7));
//				data[0] = String.valueOf(rs.getLong("personId"));
//				System.out.println(rs.getLong("personId"));
//				data[1] = rs.getString("pName");
//				data[2] = rs.getString("sex");
//				data[3] = rs.getString("birth");
//				data[4] = rs.getString("nat");
//				data[5] = rs.getString("address");
//				data[6] = rs.getString("other");
//				person_tmp.setPersonId(rs.getLong("personId"));
				person_tmp.setName(rs.getString("pName"));
				person_tmp.setSex(rs.getString("sex"));
				person_tmp.setBirth(rs.getString("birth"));
				person_tmp.setNat(rs.getString("nat"));
				person_tmp.setAddress(rs.getString("address"));
				person_tmp.setOther(rs.getString("other"));
				person_tmp.setOther(rs.getString("salary"));
//				person.setDept(Long.parseLong(deptId));

				// 获取部门信息
//				Dept dept = new Dept();
//				dept.setDeptId(rs.getLong("deptId"));
//				String[] persond = DeptDao.getDeptsinfoForSelect(dept);
////				System.out.println(persond[0]);
//				person.setPersond(persond[0]);
//				String[] depts = DeptDao.getDeptsForSelect();
//				for(int i=0;i<depts.length;i++) {
//					comboDept.addItem(depts[i]);
//				}

				list.add(person_tmp);
			}
			// 把list转换为二维数组
//			data = new String[list.size()][6];
//			for(int i=0;i<list.size();i++) {
//				data[i][0] = String.valueOf(list.get(i).getPersonId()+'-'+list.get(i).getName());
//			}
			// 把list转换为二维数组

			data = new String[list.size()][7];
			for (int i = 0; i < list.size(); i++) {
//				System.out.println(list.get(i).getPersonId());
//				data[0] = String.valueOf(list.get(i).getPersonId());
//				System.out.println(list.get(i).getName());
				data[i][0] = list.get(i).getName();
//				System.out.println(list.get(i).getSex());
				data[i][1] = list.get(i).getSex();
				data[i][2] = list.get(i).getBirth();
				data[i][3] = list.get(i).getNat();
				data[i][4] = list.get(i).getAddress();
				data[i][5] = list.get(i).getOther();
				data[i][6] = list.get(i).getSalary();
				
			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		} finally {
			// 关闭数据库连接
			DBUtil.close(rs);
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
//		System.out.println(data[1]);
		return data;
	}

	public static void update(Person person) {
//		//准备测试数据
//		Dept dept = new Dept(14,"测试一","测试二");
		//获取数据库连接
		Connection conn = DBUtil.getConnection();
		//更新
		PreparedStatement ps = null;
		String sql = "update person set "
				+ "pName=(?),sex=(?),birth=(?),nat=(?),address=(?),other=(?) where personId=(?)";
		try {
//			System.out.println(sql);
			ps = conn.prepareStatement(sql);
			ps.setLong(7, person.getPersonId());
			ps.setString(1, person.getName());
			ps.setString(2, person.getSex());
			ps.setString(3, person.getBirth());
			ps.setString(4, person.getNat());
			ps.setString(5, person.getAddress());
			ps.setString(6, person.getOther());
			
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
	public static long getNextId() {
//		Dept  = new Dept();
		Person person = new Person();
		// 获取数据库连接
		Connection conn = DBUtil.getConnection();
		// 更新
		PreparedStatement ps = null;
		ResultSet rs = null;
		int id = 0;
		String sql = "select max(personId) from person";
		try {
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			while (rs.next()) {

				person.setPersonId(rs.getInt(1));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			// 关闭数据库连接
			DBUtil.close(rs);
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
		return (person.getPersonId() + 1);
	}

	public static void add(Person person) {
		// 准备测试数据
//		Dept dept = new Dept();
		// 获取数据库连接
		Connection conn = DBUtil.getConnection();
		// 更新
		PreparedStatement ps = null;
		String sql = "insert into person(personId,pName,sex,birth,nat,address,deptId,assess,other)"
				+ "values(?,?,?,?,?,?,?,?,?)";
		try {
			ps = conn.prepareStatement(sql);
			ps.setLong(1, person.getPersonId());
			ps.setString(2, person.getName());
			ps.setString(3, person.getSex());
			ps.setString(4, person.getBirth());
			ps.setString(5, person.getNat());
			ps.setString(6, person.getAddress());
			ps.setLong(7, person.getDeptId());
			ps.setString(8, person.getAssess());
			ps.setString(9, person.getOther());
			ps.executeUpdate();
			conn.commit();
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			// 关闭数据库连接
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
	}

	public static void delete(long personId) {
		Connection conn = DBUtil.getConnection();
		// 更新
		PreparedStatement ps = null;
		String sql = "delete * from person where personId=(?)";
		try {
//			System.out.println(sql);
			ps = conn.prepareStatement(sql);
			ps.setLong(1, personId);
			ps.executeUpdate();
//			conn.commit();
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			// 关闭数据库连接
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
	}
}
