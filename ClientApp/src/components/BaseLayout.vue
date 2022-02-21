<template>
  <div class="layout">
    <div class="card">
      <slot name="left" />
    </div>
    <div class="main">
      <slot />
    </div>
    <div class="card">
      <slot name="right" />
    </div>
  </div>
</template>

<style>
.layout {
  display: flex;
  background-color: #f7f8f9;
}

.card {
  min-width: 270px;
  background: #ffffff;
  border: 2px solid #e6e7e7;
  box-sizing: border-box;
  border-radius: 5px;
  margin: 40px;
  height: fit-content;
  display: inline-block;
}
</style>
