import { h } from "vue"; // h = createElement in Vue 3
import PomodoroView from "/src/views/TimerView.vue";

console.log("Logging: Presenter");

// Plain JS component using the render function
const PomodoroMain = {
  name: "Search",
  components: { PomodoroView },
  render() {
    return h("div", {}, [
      h(PomodoroView)
    ]);
  }
};

export { PomodoroMain };