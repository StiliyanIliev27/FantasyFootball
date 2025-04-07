"use client";

import { useState } from "react";
import { useRouter } from "next/navigation";
import { useDispatch } from "react-redux";

import InputField from "@/app/components/auth/InputField";
import AuthForm from "./AuthForm";
import { signIn } from "@/app/api/auth";
import { login } from "@/lib/store/authSlice";

export default function SignInForm() {
  const dispatch = useDispatch();
  const router = useRouter();
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);

  const [formData, setFormData] = useState({
    email: "",
    password: "",
  });

  async function handleSubmit(event) {
    event.preventDefault();
    setIsLoading(true);
    setError(null); // clear previous errors

    const { email, password } = formData;

    try {
      const response = await signIn(email, password);

      if (response.error) {
        setError(response.error); // error returned from backend
        return;
      }

      if (response.result.token && response.statusCode === 200) {
        dispatch(
          login({
            user: response.result.nickname,
            token: response.result.token,
          })
        );
      }

      router.push('/');
      resetForm();
    } catch (err) {
      setError("An error occurred while signing in.");
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
