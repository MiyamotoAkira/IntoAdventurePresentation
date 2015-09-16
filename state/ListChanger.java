import java.util.List;
import java.util.ArrayList;

public class ListChanger {
	public static void main(String[] args) {
		List<Integer> list = new ArrayList<Integer>();
		list.add(5);
		list.add(4);

		List<Integer> list2 = list;
		list2.add(3);
		list2.add(2);
		list2.add(1);

		System.out.println("first list:" + list);

		System.out.println("second list:" + list2);
	}
}
