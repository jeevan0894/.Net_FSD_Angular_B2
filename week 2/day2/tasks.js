
let tasks=[];
const getTasks =()=>tasks;
const setTasks= newTasks=>{
    tasks=newTasks;
};
const delay=()=>{
    return new Promise(resolve=>setTimeout(resolve,500));
};
export const addTaskAsync = async task => {
  await delay();
  setTasks([...tasks, task]);
  return `Task added: ${task}`;
};
export const deleteTaskAsync = async task => {
  await delay();
  const updated = tasks.filter(t => t !== task);
  setTasks(updated);
  return `Task deleted: ${task}`;
};
export const listTasksAsync = async () => {
  await delay();
  return `
------ TASK LIST ------
${tasks.map(t => `• ${t}`).join("\n")}
-----------------------
  `;
};
