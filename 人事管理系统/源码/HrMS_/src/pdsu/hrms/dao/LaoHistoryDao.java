package pdsu.hrms.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.LinkedList;
import java.util.List;

import javax.swing.JOptionPane;

import pdsu.hrms.model.History;
import pdsu.hrms.model.Person;
import pdsu.hrms.view.Panel41;

public class LaoHistoryDao {
	public static void update(Person person) {
//		//׼����������
//		Dept dept = new Dept(14,"����һ","���Զ�");
// ��ȡ���ݿ�����
		Connection conn = DBUtil.getConnection();
// ����
		PreparedStatement ps = null;
		String sql = "update person set salary=(?) where personId=(?)";
		try {
			System.out.println(sql);
			ps = conn.prepareStatement(sql);
//	System.out.println(person.getPersonId());
//	System.out.println(person.getDeptId());
			ps.setLong(2, person.getPersonId());
			ps.setString(1, person.getSalary());
			ps.executeUpdate();
			conn.commit();
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			// �ر����ݿ�����
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
	}
	public static String[][] getHistoryPersonForTable() {
		// ��ȡ���ݿ�����
		Connection conn = DBUtil.getConnection();
		PreparedStatement ps = null;
		ResultSet rs = null;
		// �洢�����õļ�����
		List<History> list = new LinkedList<History>();
		String[][] data = null;
		try {
			// ��ѯ
			String sql = "select histId,oldInfo,newInfo,chgDate,personId,chgNum from histroy where histType like '���ʷ���'";
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			// ��������
			while (rs.next()) {
				History history = new History();
				history.setHistId(rs.getLong("histId"));
				// ��ȡ����
				Person person = new Person();
				person.setPersonId(rs.getLong("personId"));
				String[][] name = PersonDao.getPersonsForSelect(person);
				System.out.println(name[0][0]);
				history.setName(name[0][0]);
				//��ȡԭнˮ
				System.out.println(rs.getString("oldInfo"));
				history.setOldInfo(rs.getString("oldInfo"));
//				history.setOldSalary();
//				person.setPersonId(rs.getLong("personId"));
//				String[][] salary = PersonDao.getPersonsForSelect(person);
//				System.out.println(name[0][0]);
				//��ȡ��нˮ
				history.setNewInfo(rs.getString("newInfo"));
//				history.setNewSalary(rs.getString("newInfo"));
//				Person person = new Person();
//				Dept olddept = new Dept();
//				olddept.setDeptId(Long.parseLong(rs.getString("oldInfo")));
//				String[] olddeptname = DeptDao.getDeptsinfoForSelect(olddept);
				//��ȡ��нˮ
//				history.set
				
//				history.setOldInfo(rs.getString("oldInfo"));
				//��ȡ���ο���
//				Dept newdept = new Dept();
//				newdept.setDeptId(Long.parseLong(rs.getString("newInfo")));
//				String[] newdeptname = DeptDao.getDeptsinfoForSelect(newdept);
//				history.setNewInfo(rs.getString("newInfo"));
				//��ȡ�������
				history.setChgNum(rs.getLong("chgNum"));
//				history.setOldInfo(rs.getString("oldInfo"));
//				history.setNewInfo(rs.getString("newInfo"));
				//��ȡ�������
				history.setChgDate(rs.getString("chgDate"));

//				Person person = new Person();
////				dept.setDeptId(rs.getLong("deptId"));
////				dept.setDept1Name(rs.getString("dept1Name"));
////				dept.setDept2Name();
//
//				person.setPersonId(rs.getLong("personId"));
//				person.setName(rs.getString("pName"));
//				person.setSex(rs.getString("sex"));

//				// ��ȡ������Ϣ
//				Dept dept = new Dept();
//				dept.setDeptId(rs.getLong("deptId"));
//				String[] persond = DeptDao.getDeptsinfoForSelect(dept);
////				System.out.println(persond[0]);
//				person.setPersond(persond[0]);

//				person.setSalary(rs.getString("salary"));
//				person.setAssess(rs.getString("assess"));
//				person.setDept(Long.parseLong(deptId));

//				String[] depts = DeptDao.getDeptsForSelect();
//				for(int i=0;i<depts.length;i++) {
//					comboDept.addItem(depts[i]);
//				}

				list.add(history);
			}
			// ��listת��Ϊ��ά����
//			data = new String[list.size()][6];
//			for(int i=0;i<list.size();i++) {
//				data[i][0] = String.valueOf(list.get(i).getPersonId()+'-'+list.get(i).getName());
//			}
			// ��listת��Ϊ��ά����
			data = new String[list.size()][6];
			for (int i = 0; i < list.size(); i++) {
				data[i][0] = String.valueOf(list.get(i).getHistId());
				data[i][1] = list.get(i).getName();
				data[i][2] = list.get(i).getOldInfo();
				data[i][3] = list.get(i).getNewInfo();
				data[i][4] = String.valueOf(list.get(i).getChgNum());
				data[i][5] = list.get(i).getChgDate();
//				System.out.println(list.get(i).getChgDate());
//				
			}
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		} finally {
			// �ر����ݿ�����
			DBUtil.close(rs);
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
		return data;
	}
	public static void addHistroy(Person person,History history) {
		// ׼����������
//		Dept dept = new Dept();
		// ��ȡ���ݿ�����
		Connection conn = DBUtil.getConnection();
		// ����
		PreparedStatement ps = null;
		String sql = "insert into histroy(histId,histType,oldInfo,newInfo,chgDate,chgNum,personId)" + "values(?,?,?,?,?,?,?)";
		try {
			ps = conn.prepareStatement(sql);
			ps.setLong(1, getHistoryNextId());
			ps.setString(2, "���ʷ���");
			ps.setString(3,history.getOldInfo());
			ps.setString(4,history.getNewInfo());
			//��ȡʱ��
			SimpleDateFormat df = new SimpleDateFormat("yyyy-MM-dd");//�������ڸ�ʽ
			ps.setString(5, df.format(new Date()));// new Date()Ϊ��ȡ��ǰϵͳʱ��
			ps.setLong(6,getNextId(person));
			ps.setLong(7, person.getPersonId());
//			ps.setString(2, );
//			ps.setString(3, dept.getDept2Name());
			ps.executeUpdate();
			conn.commit();
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			// �ر����ݿ�����
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
	}
	public static long getHistoryNextId() {
		History history = new History();
		//��ȡ���ݿ�����
		Connection conn = DBUtil.getConnection();
		//����
		PreparedStatement ps = null;
		ResultSet rs = null;
		int id=0;
		String sql = "select max(histId) from histroy";
		try {
			ps = conn.prepareStatement(sql);
			rs = ps.executeQuery();
			while(rs.next()) {
				
				history.setHistId(rs.getInt(1));
			}
		}catch(SQLException e) {
			e.printStackTrace();
		}finally {
			//�ر����ݿ�����
			DBUtil.close(rs);
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
		return (history.getHistId()+1);
	}
	public static long getNextId(Person person) {
		History history = new History();
		//��ȡ���ݿ�����
		Connection conn = DBUtil.getConnection();
		//����
		PreparedStatement ps = null;
		ResultSet rs = null;
		int id=0;
		String sql = "select max(chgNum) from histroy where histType like '���ʷ���' and personId=(?)";
		try {
			ps = conn.prepareStatement(sql);
			ps.setLong(1, person.getPersonId());
			rs = ps.executeQuery();
			while(rs.next()) {
				
				history.setHistId(rs.getInt(1));
			}
		}catch(SQLException e) {
			e.printStackTrace();
		}finally {
			//�ر����ݿ�����
			DBUtil.close(rs);
			DBUtil.close(ps);
			DBUtil.close(conn);
		}
		return (history.getHistId()+1);
	}
}
