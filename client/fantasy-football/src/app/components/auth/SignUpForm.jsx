"use client";

import { useState } from "react";
import AuthForm from "./AuthForm";
import InputField from "./InputField";

export default function SignUpForm() {
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState(null);
  const [fieldErrors, setFieldErrors] = useState({});
  const [touchedFields, setTouchedFields] = useState({});

  const [formData, setFormData] = useState({
    nickname: "",
    email: "",
    profilePicture: "",
    password: "",
    confirmPassword: "",
  });

  function handleChange(event) {
    const { name, value } = event.target;

    setFormData((prev) => ({ ...prev, [name]: value }));
    setTouchedFields((prev) => ({ ...prev, [name]: true }));

    validateField(name, value);
  }

  function validateField(name, value) {
    let errorMsg = "";

    switch (name) {
      case "nickname":
        if (value.length < 3 || value.length > 50) errorMsg = "Nickname must be between 3 and 50 characters long.";
        break;
      case "email":
        if (!/\S+@\S+\.\S+/.test(value)) errorMsg = "Invalid email format.";
        break;
      case "password":
        if (value.length < 6)
          errorMsg = "Password must be at least 6 characters.";
        break;
      case "confirmPassword":
        if (value !== formData.password) errorMsg = "Passwords do not match.";
        break;
    }

    setFieldErrors((prev) => ({
      ...prev,
      [name]: errorMsg,
    }));
  }

  function validateForm() {
    const errors = {};

    if (formData.nickname.length < 3 || formData.nickname.length > 50) errors.nickname = "Nickname must be between 3 and 50 characters long.";
    if (!/\S+@\S+\.\S+/.test(formData.email))
      errors.email = "Invalid email format.";
    if (!formData.password || formData.password.length < 6)
      errors.password = "Password must be at least 6 characters.";
    if (formData.password !== formData.confirmPassword)
      errors.confirmPassword = "Passwords do not match.";

    setFieldErrors(errors);

    const allValid = Object.keys(errors).length === 0;

    if (!allValid) setError("Please fix the errors above.");
    else setError(null);

    return allValid;
  }

  function handleSubmit(event) {
    event.preventDefault();
    setIsLoading(true);

    if (!validateForm()) {
      setIsLoading(false);
      return;
    }

    // Simulate API call
    setTimeout(() => {
      setIsLoading(false);
      resetForm();
    }, 1000);
  }

  function resetForm() {
    setFormData({
      nickname: "",
      email: "",
      profilePicture: "",
      password: "",
      confirmPassword: "",
    });
    setFieldErrors({});
    setError(null);
    setTouchedFields({});
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
        required
        errorMessage={fieldErrors.nickname}
        isTouched={touchedFields.nickname}
      />

      <InputField
        label="Email"
        type="email"
        name="email"
        value={formData.email}
        onChange={handleChange}
        required
        errorMessage={fieldErrors.email}
        isTouched={touchedFields.email}
      />

      <InputField
        label="Password"
        type="password"
        name="password"
        value={formData.password}
        onChange={handleChange}
        required
        errorMessage={fieldErrors.password}
        isTouched={touchedFields.password}
      />

      <InputField
        label="Confirm Password"
        type="password"
        name="confirmPassword"
        value={formData.confirmPassword}
        onChange={handleChange}
        required
        errorMessage={fieldErrors.confirmPassword}
        isTouched={touchedFields.confirmPassword}
      />
    </AuthForm>
  );
}
