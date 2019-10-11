import java.util.*;
class Main {
	public static void main(String[] args) {
		List<Integer> list = new ArrayList<>();
		for (int i = 0; i < 100; ++i) list.add(i);
		for (int i : list) System.out.println(i);
	}
}