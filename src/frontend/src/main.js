import { createApp } from 'vue'
import { createRouter, createWebHistory } from 'vue-router'

import App from './App.vue'
import IndexView from './views/IndexView.vue'

import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';

const router = createRouter({
    history: createWebHistory(),
    routes: [
        { path: '/', component: IndexView },
    ]
});

const app = createApp(App)
app.use(router)
app.mount('#app')
