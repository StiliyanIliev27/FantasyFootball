"use client";

import { useState } from "react";

import AuthForm from "./AuthForm";
import InputField from "./InputField";

export default function SignUpForm() {
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState();

  const [formData, setFormData] = useState({
    nickname: "",
    email: "",
    profilePicture: "",
    password: "",
    confirmPassword: "",
  });

  function handleSubmit(event) {
    event.preventDefault();

    setIsLoading(true);



    setIsLoading(false);
    resetForm();
  }

  function handleChange(event) {
    const { name, value } = event.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  }

  function resetForm() {
    setFormData({
      nickname: "",
      email: "",
      profilePicture: "",
      password: "",
      confirmPassword: "",
    });
    setError(null);
  }

  return (
    <AuthForm type="sign-up" isLoading={isLoading} onSubmit={handleSubmit}>
      {error && <p className="text-red-500 mb-3">{error}</p>}

      <InputField
        label="Nickname"
        type="text"
        name="nickname"
        value={formData.nickname}
        onChange={handleChange}
        error={error}
        required={true}
      />

      <InputField
        label="Email"
        type="email"
        name="email"
        value={formData.email}
        onChange={handleChange}
        error={error}
        required={true}
      />

      <InputField
        label="Password"
        type="password"
        name="password"
        value={formData.password}
        onChange={handleChange}
        error={error}
        required={true}
      />

      <InputField
        label="Confirm Password"
        type="password"
        name="confirm-password"
        value={formData.confirmPassword}
        onChange={handleChange}
        error={error}
        required={true}
      />
    </AuthForm>
  );
}
