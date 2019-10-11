const list: number[] = new Array<number>();
for (let i: number = 0; i < 100; ++i) list.push(i);
for (let i of list) console.log(i);