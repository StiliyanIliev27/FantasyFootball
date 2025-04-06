"use client";

import { useState } from "react";
import InputField from "@/app/components/auth/InputField";
import AuthForm from "./AuthForm";

export default function SignInForm() {
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);

  const [formData, setFormData] = useState({
    email: "",
    password: "",
  });

  async function handleSubmit(event) {
    event.preventDefault();
    setIsLoading(true);

    const { email, password } = formData;

    try {
      const response = await signIn(email, password);

      if (response.error) {
        setError(response.error);
        return;
      }

      if (response.statusCode === 200) {
        console.log("Logged in successfully:", response.data);
        resetForm();
      }
    } finally {
      setIsLoading(false);
    }
  }

  function handleChange(event) {
    const { name, value } = event.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  }

  function resetForm() {
    setFormData({ email: "", password: "" });
    setError(null);
  }

  return (
    <AuthForm type="sign-in" isLoading={isLoading} onSubmit={handleSubmit}>
      {error && <p className="text-red-500 mb-3">{error}</p>}

      <InputField
        label="Email"
        type="email"
        name="email"
        value={formData.email}
        onChange={handleChange}
        error={error}
        required
      />

      <InputField
        label="Password"
        type="password"
        name="password"
        value={formData.password}
        onChange={handleChange}
        error={error}
        required
      />
    </AuthForm>
  );
}
