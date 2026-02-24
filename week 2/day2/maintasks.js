import {
  addTaskAsync,
  deleteTaskAsync,
  listTasksAsync
} from "./tasks.js";

const run = async () => {
  console.log(await addTaskAsync("Study ES6"));
  console.log(await addTaskAsync("Clean room"));
  console.log(await addTaskAsync("Write notes"));

  console.log(await deleteTaskAsync("Clean room"));

  console.log(await listTasksAsync());
};

run();